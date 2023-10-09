using Microsoft.AspNetCore.Mvc;

namespace Lab01_1._1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
    }
}
