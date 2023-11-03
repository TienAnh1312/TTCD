using Lab05.Th.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;

namespace Lab05.Th.Controllers
{
    public class ProductController : Controller
    {
        // GET: productController
        public ActionResult Index()
        {
            var data = Datalocal._products;
            return View(data);
        }

        // GET: productController/Details/5
        public ActionResult Details(int id)
        {
            var data = Datalocal._products.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        // GET: productController/Create
        public ActionResult Create()
        {
            //tạo dữ liệu cho Combobox Category
            ViewData["categoryId"] = new SelectList(Datalocal._categories, "Id", "Name",1);
            //tạo mã sản phẩm tự tăng
            var id = Datalocal._products.MaxBy(x => x.Id).Id;
            ViewBag.id = id+1;
            return View();
        }

        // POST: productController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                //Upload file
                var files = HttpContext.Request.Form.Files;
                if(files.Count > 0 && files[0] != null) 
                {
                    var file = files[0];
                    var filename = file.FileName.ToLower();
                    //tạo thư mục trên sever để chứa tập tên 
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products" ,filename);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        product.Image = "images/products/" + filename;
                    }
                }

                product.CreateDate  = DateTime.Now;
                product.CreateBy = "TA";
                Datalocal._products.Add(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: productController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Datalocal._products.FirstOrDefault(x => x.Id == id);
            //tạo dữ liệu cho Combobox Category
            ViewData["categoryId"] = new SelectList(Datalocal._categories, "Id", "Name", data.CategoryId);
            return View(data);
        }

        // POST: productController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                //Upload file
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0 && files[0] != null)
                {
                    var file = files[0];
                    var filename = file.FileName.ToLower();
                    //tạo thư mục trên sever để chứa tập tên 
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", filename);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        product.Image = "images/products/" + filename;
                    }
                }
                for (int i = 0; i < Datalocal._products.Count; i++)
                {
                    if (Datalocal._products[i].Id == id)
                    {
                        Datalocal._products[i] = product;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: productController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Datalocal._products.FirstOrDefault(x => x.Id == id);

            return View(data);
        }

        // POST: productController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                foreach (var item in Datalocal._products)
                {
                    if (item.Id == id)
                    {
                        Datalocal._products.Remove(item);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
