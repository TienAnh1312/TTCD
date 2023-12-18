using Lab09_CartPay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Lab09_CartPay.Controllers
{/// <summary>
/// 
/// </summary>
    public class CartController : Controller, IActionFilter
    {
        private readonly Lab09CartPayContext _context ;
        private List<Cart> carts = new List<Cart>();
        public CartController(Lab09CartPayContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Cart");
            if (cartInSession != null)
            {
                //nếu cartInSession không null thì gán  dữ liệu cho biến cart
                //chuyển dữ liệu qua json
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            base.OnActionExecuting(context);
        }
        public ActionResult Index()
        {
            float total = 0;
            foreach (var item in carts) { 
                total += item.Quantity * item.Price;
            }
            ViewBag.Total = total; //Tổng tiền của đơn hàng
            return View(carts);
        }

        /// <summary>
        /// Code logic cho chức năng  thêm sản phẩm
        /// </summary>
        /// <param name="id"></param>
        public IActionResult Add(int id)
        {
            if (carts.Any(c => c.Id == id)) //Nếu sản phẩm này đã có trong giỏ hàng
            {
                carts.Where(c => c.Id == id).First().Quantity += 1; //Tăng số lượng
            }
            else //Nếu sản phẩm chưa có trong giỏ hàng, thêm sản phẩm vào giỏ hàng  
            {
                var p = _context.Products.Find(id); //Tìm sản phẩm cần mua trong bảng sản phẩm 

                //tạo mới một sản phẩm để thêm vào giỏ hàng
                var item = new Cart()
                {
                    Id = p.Id,
                    Name = p.Title,
                    Price = (float)p.PriceNew.Value,
                    Quantity = 1,
                    Image = p.Image,
                    Total = (float)p.PriceNew.Value * 1
                };
                //Thêm sản phẩm vào giỏ hàng
                carts.Add(item);
            }    
            //Lưu Cart vào session, cần phải chuyển dữ liệu json
            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Code logic cho chức năng xóa sản phẩm
        /// </summary>
        /// <param name="id"></param>
        public IActionResult Remove(int id)
        {
            if(carts.Any(c => c.Id == id))
            {
                var item = carts.Where(c => c.Id == id).First();
                //Thực hiện xóa
                carts.Remove(item);
                //Lưu cart vào session, cần phải chuyển sang dữ liệu json
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));     
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Code logic cho chức năng Cập nhập dữ liệu trong giỏ hàng
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity"></param>
        public IActionResult Update(int id, int quantity)
        {
            if(carts.Any(c => c.Id == id))
            {
                //tìm sản phẩm trong giỏ hàng và cập nhập lại số lượng mới
                carts.Where(c => c.Id == id).First().Quantity = quantity;
                float price = carts.Where(c => c.Id == id).First().Price;
                carts.Where(c => c.Id == id).First().Total = quantity* price;

                //Lưu cart vào session, cần phải chuyển dữ liệu qua json
                HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));  
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Code logic cho chức năng Xóa dữ liệu trong giỏ hàng
        /// </summary>
        public IActionResult Clear()
        {
            HttpContext.Session.Remove("My-Cart");
            return RedirectToAction("Index");
        }

        public IActionResult Orders()
        {
            if(HttpContext.Session.GetString("Member") == null)
            {
                return Redirect("/customermember/index/?url=/cart/orders");
                //nếu ng dùng chưa đăng nhập
            }
            else
            {
                var dataMember = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                ViewBag.Customer = dataMember;

                float total = 0;
                foreach( var item in carts) {
                    total += item.Quantity * item.Price;
                }
                ViewBag.total = total;

                //phương thức thanh toán
                var dataPay = _context.PaymentMethods.ToList();
                ViewData["IdPayment"] = new SelectList(dataPay, "Id", "Name", 1);
            }
            return View(carts);
        }
        /// <summary>
        /// 
        /// Khi người dùng click vào nút thanh toán:
        /// - Thục hiện thêm dữ liệu vào bảng Orders, OrderDetails
        /// - Giải phóng Session cart
        /// </summary>
        public async Task<IActionResult> OrderPay(IFormCollection form)
        {
            try
            {
                //thêm hàng orders
                var order = new Order();
                order.NameReciver = form["NameReciver"];
                order.Email = form["Email"];
                order.Phone = form["Phone"];
                order.Address = form["Address"];
                order.Notes = form["Notes"];
                order.OrdersDate = DateTime.Now;
                if (!string.IsNullOrEmpty(form["Idpayment"]))
                {
                    order.Idpayment = long.Parse(form["Idpayment"]);
                }
                else
                {

                }

                var dataMember =
                    JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                order.Idcustomer = dataMember.Id;

                decimal total = 0;
                foreach( var item in carts) {
                    total += item.Quantity * (decimal)item.Price;
                }
                order.TotalMoney = total;
                //tạo orderId
                var strOrderId = "DH";

                string timestamp = DateTime.Now.ToString("yyyy-MM-dd.HH-mm-ss.fff");
                strOrderId += "." + timestamp;
                order.Idorders = strOrderId;

                _context.Add(order);
                await _context.SaveChangesAsync();

                //lấy id bảng orders
                var dataOrder = _context.Orders.OrderByDescending(x => x.Id).FirstOrDefault();

                foreach(var item in carts)
                {
                    Orderdetail od = new Orderdetail();
                    od.Idord = dataOrder.Id;
                    od.Idproduct = item.Id;
                    od.Qty = item.Quantity;
                    od.Price = (decimal)item.Price;
                    od.Total = (decimal)item.Total;        
                    od.ReturnQty = 0;

                    _context.Add(od);
                    await _context.SaveChangesAsync();
                }
                HttpContext.Session.Remove("My-Cart");
            }catch(Exception ex)
            {
                throw;
            }
            return View();
        }
    }
}
