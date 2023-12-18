using Lab09_th.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Lab09_th.Controllers
{/// <summary>
/// 
/// </summary>
    public class CartController : Controller, IActionFilter
    {
        private readonly Lab09Context _context ;
        private List<Cart> carts = new List<Cart>();
        public CartController(Lab09Context context)
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
    }
}
