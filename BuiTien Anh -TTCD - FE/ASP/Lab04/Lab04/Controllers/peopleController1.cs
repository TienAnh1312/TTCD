using Lab04.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.IO;

namespace Lab04.Controllers
{
    public class peopleController1 : Controller
    {
        // GET: peopleController1
        /// <summary>
        /// //Index: Hiển thị danh sách dữ liệu peoples
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var _peoples = DataLocal.GetPeoples();  
            return View(_peoples);
        }

        // GET: peopleController1/Details/5
        public ActionResult Details(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // GET: peopleController1/Create
        public ActionResult Create()
        {
            People people = new People();
            return View(people);
        }

        // POST: peopleController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(People model)
        {
            try
            {
                //upload file
                var files = HttpContext.Request.Form.Files;
                //using System.linq;
                if (files.Count() > 0 && files[0].Length > 0) 
                {
                    var file = files[0];
                    var FileName = file.FileName;

                    //using System.IO
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\Avatar", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "Images/Avatar/" + FileName; //gán tên ảnh cho thuộc tính Avatar
                    }
                }
                //thêm peoples vào danh sách Datalocal
                DataLocal._peoples.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.error = ex.Message;
                return View(model);
            }
        }

        // GET: peopleController1/Edit/5
        public ActionResult Edit(int id)
        {
            var people = DataLocal.GetPeopleById(id);
            return View(people);
        }

        // POST: peopleController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, People model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if(files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\Avatar", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "Images/Avatar" + FileName;
                    }
                }  
                //Cập nhập model vào danh sách dataLocal
                for(int i = 0; i < DataLocal._peoples.Count; i++)
                {
                    if (DataLocal._peoples[i].Id == id)
                    {
                        DataLocal._peoples[i] = model;
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

        // GET: peopleController1/Delete/5
        public ActionResult Delete(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // POST: peopleController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                for (int i = 0; i < DataLocal._peoples.Count; i++)
                {
                    if (DataLocal._peoples[i].Id == id)
                    {
                        DataLocal._peoples.RemoveAt(i);
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
