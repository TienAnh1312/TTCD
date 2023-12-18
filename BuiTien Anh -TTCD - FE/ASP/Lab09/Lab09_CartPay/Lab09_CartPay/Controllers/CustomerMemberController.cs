using Lab09_CartPay.Areas.Admin.Models;
using Lab09_CartPay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Text;

namespace Lab09_CartPay.Controllers
{
    public class CustomerMemberController : Controller
    {
        private readonly Lab09CartPayContext _context;
        public CustomerMemberController(Lab09CartPayContext context)
        {
            _context = context;
        }
        
        public IActionResult Index(string url)
        {
            if(HttpContext.Session.GetString("Member") != null)
            {
                var dataLogin = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("Member"));
                ViewBag.Customer = dataLogin;
            }
            ViewBag.UrlAction = url;
            return View();  
        }
        /// <summary>
        /// xử lý chức năng khi người dùng click vào nút Registry
        /// </summary>
        [HttpPost]
        public IActionResult Registry(Customer model) 
        {
            try
            {
                var pass = Utilities.Utils.GetSHA26Hash(model.Password);
                model.Password = pass;
                model.CreatedDate = DateTime.Now;
                model.UpdatedDate = DateTime.Now;
                model.Isactive = 1;
                _context.Add(model);
                _context.SaveChanges();
                return View();
            }    
            catch (Exception ex) 
            {
                TempData["errorRegistry"] = "Lỗi đăng ký; " + ex.Message;
                return RedirectToAction("Index");
            }
           
        }
        /// <summary>
        /// Chức nang đăng nhập
        /// </summary
        /// <param name="model"><param/>
        /// <param name="urlAction"><param/>
        [HttpPost]
        public IActionResult Login(Login model, string urlAction)
        {
            var pass = Utilities.Utils.GetSHA26Hash(model.Password);
            var data = _context.Customers.Where(x => x.Isactive == 1).Where(x => x.Username.Equals(model.UserOrEmail) ||
            x.Email.Equals(model.UserOrEmail)).FirstOrDefault(x => x.Password.Equals(pass));
            var datalogin = data.ToJson();
            if(data != null)
            {
                //Lưu sessionkhi đăng nhập thành công
                HttpContext.Session.SetString("Member", datalogin);
                if (!string.IsNullOrEmpty(urlAction)) 
                {
                    return Redirect(urlAction);
                }
                return RedirectToAction("Index");
            }
            TempData["errLogin"] = "Lỗi đăng nhập";
            return RedirectToAction("Index");
        }
       
    }
}
