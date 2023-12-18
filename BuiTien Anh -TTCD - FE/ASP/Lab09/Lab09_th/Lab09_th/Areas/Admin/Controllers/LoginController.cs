using Lab09_th.Areas.Admin.Models;
using Lab09_th.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;


namespace Lab09_th.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly Lab09Context _context;
        public LoginController( Lab09Context context)
        {
            _context = context;
        }
        [HttpGet] //Get, hiển thị form để nhập dữ liệu
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] //Post -> khi submit form
        public IActionResult Index(Login model)
        {
            if(!ModelState.IsValid)
            {
                return View(model); // trả về trạng thái lỗi
            }
            //xử lý logic phần đăng nhập
            var pass = GetSHA26Hash(model.Password);
            var dataLogin = _context.AdminUser.Where(x => x.Email.Equals(model.Email) && x.Password.Equals(pass)).FirstOrDefault();
            if (dataLogin != null)
            {
                //Lưu  Session khi đăng nhập thành công 
                HttpContext.Session.SetString("AdminLogin", model.Email);
                return RedirectToAction("Index", "Dashboard");
            }
            return View(model);//trả về trạng thái lỗi


            //// xử lý logic phần đăng nhập      
            //HttpContext.Session.SetString("AdminLogin", model.Email);
            //return RedirectToAction("Index", "Dashboard");
        }


        [HttpGet] //Thoát đăng nhập, hủy Session
        public IActionResult Logout() {
            HttpContext.Session.Remove("AdminLogin"); // hủy Session với Key AdminLogin đã lưu trước đó
            return RedirectToAction("Index");
        }

        static string GetSHA26Hash(string input)
        {
            string hash = "";
            using (var sha256 = new SHA256Managed())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
            return hash;
        }
    }
}
