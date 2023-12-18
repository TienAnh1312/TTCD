using Lab09_th.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab09_th.Controllers
{
    public class ProductController : Controller
    {
        private readonly Lab09Context _context;
        public ProductController(Lab09Context context)
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
