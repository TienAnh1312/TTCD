using Lab05_demo.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Lab05_demo.Controllers
{
    public class MemberController : Controller
    {
        // GET: MemberController
        public static List<Member> list = new List<Member>();
        public ActionResult Index()
        {

            return View(list);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}

            //menual Validation
            string msg = "";
            bool validate = true;
            //kiểm tra username: 3 - 20
            if(member.UserName.Length < 3 || member.UserName.Length > 20)
            {
                msg = "<li> Usernmae có độ dài từ 3 -20 ký tự <li/>";
            }
            //kiểm tra email đúng định dạng
            string patternEmail = @"[a-zA-z0-9._+-] +@[a-z0-9._]+\.[a-z]{2,4}$";
            if(!Regex.IsMatch(member.Email, patternEmail))
            {
                msg += "<li> Email chưa đúng định dạng <li/>";
                validate = false;
            }
            //kiểm tra năm sinh
            if (member.Birthday.AddYears(18) > DateTime.Now)
            {
                msg += "<li> Bạn chưa đủ 18 tuổi <li/>";
            }
            //kiểm tra phone
            string patternPhone = @"^0\d{9,11}$";
            if(!Regex.IsMatch(member.Phone, patternPhone))
            {
                msg += "<li> Số điện thoại chưa đúng <li/>";
            }

            if (validate == true)
            {
                member.MemberId = Guid.NewGuid().ToString();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.msg = "<div class='alert alert-danger'>" + msg + "<div/>";
                return View(member);
            }
           
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
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

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
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
