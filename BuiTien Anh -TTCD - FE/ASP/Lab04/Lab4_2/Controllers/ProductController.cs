using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.IO;
using Lab4_2.Models;

namespace Lab4_2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var _product = DataLocal.Getproducts();
            return View(_product);
        }
      
        public ActionResult Details(int id)
        {
            var product = DataLocal.GetProductById(id);
            return View(product);
        }
      
        public ActionResult Edit(int id)
        {
            var product = DataLocal.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\Avatar", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Image = "Images/Avatar" + FileName;
                    }
                }
                //Cập nhập model vào danh sách dataLocal
                for (int i = 0; i < DataLocal._product.Count; i++)
                {
                    if (DataLocal._product[i].Id == id)
                    {
                        DataLocal._product[i] = model;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
