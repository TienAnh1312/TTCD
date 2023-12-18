using Lab09_CartPay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab09_CartPay.Controllers
{
    public class ProductController : Controller
    {
        private readonly Lab09CartPayContext _context;
        public ProductController(Lab09CartPayContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Products.ToListAsync();
            return View(data);
        }
    }
}
