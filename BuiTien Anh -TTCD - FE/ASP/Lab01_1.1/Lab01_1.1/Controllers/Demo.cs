using Microsoft.AspNetCore.Mvc;

namespace Lab01_1._1.Controllers
{
    public class Demo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
