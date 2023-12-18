using Lab09_CartPay.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Lab09_CartPay.Areas.Admin.Controllers
{
    //[Area("Admin")]
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
