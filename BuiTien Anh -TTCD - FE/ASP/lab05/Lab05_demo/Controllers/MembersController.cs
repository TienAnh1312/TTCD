using Lab05_demo.Models.DataModels;
using Lab05_demo.Models.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab05_demo.Controllers
{
    public class MembersController : Controller
    {
        // GET: MembersController
        public static readonly List<MemberView> _members = new List<MemberView>();
        public ActionResult Index()
        {
            return View(_members);
        }

        // GET: MembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemberView memberView)
        {
            if (ModelState.IsValid)
            {
                var m = new MemberView()
                {
                    MemberId = Guid.NewGuid().ToString(),
                    UserName = memberView.UserName,
                    FullName = memberView.FullName,
                    Email = memberView.Email,
                    PassWord = memberView.PassWord,
                    Phone = memberView.Phone,
                    Birthday = (DateTime)memberView.Birthday,
                };
                _members.Add(m);
                return RedirectToAction(nameof(Index));
            }
            else { return View(memberView); }
           
        }

        // GET: MembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
