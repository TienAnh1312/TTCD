using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,Name = "Tiến Anh",
                    Email = "anh@gmail.com",
                    Phone = "0828345288",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/02.jpg"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(2003,12,13)
                },
              new Account()
                {
                    Id = 12,
                    Name = "Bùi Tiến Anh",
                    Email = "anh333@gmail.com",
                    Phone = "0828345288",
                    Address = "Tuyên Quang",
                    Avatar = Url.Content("~/Avatar/03.jpg"),
                    Gender = 1,
                    Bio = "Sinh sống lâu rr",
                    Birthday = new DateTime(2002, 7, 15)
                },
                new Account()
                    {
                        Id = 3,Name = "Tiến Anh Bùi",
                        Email = "anhaa12@gmail.com",
                        Phone = "0828345288",
                        Address = "Chiêm Hóa",
                        Avatar = Url.Content("~/Avatar/04.jpg"),
                        Gender = 1, Bio = "nnnn",
                        Birthday = new DateTime(2001,10,6)
                 },
            };
           
            //gửi đối tượng account qua view
            ViewBag.Accounts = accounts;
            return View();
        }
        //định nghĩa url và nam cho action
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,Name = "Tiến Anh",
                    Email = "anh@gmail.com",
                    Phone = "0828345288",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/02.jpg"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(2003,12,13)
                },
                new Account()
                {
                    Id = 12,
                    Name = "Bùi Tiến Anh",
                    Email = "anh333@gmail.com",
                    Phone = "0828345288",
                    Address = "Tuyên Quang",
                    Avatar = Url.Content("~/Avatar/03.jpg"),
                    Gender = 1,
                    Bio = "Sinh sống lâu rr",
                    Birthday = new DateTime(2002, 7, 15)
                },
                new Account()
                {
                    Id = 3,Name = "Tiến Anh Bùi",
                    Email = "anhaa12@gmail.com",
                    Phone = "0828345288",
                    Address = "Chiêm Hóa",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Gender = 1, Bio = "nnnn",
                    Birthday = new DateTime(2001,10,6)
                 },
            };

            //sử dụng using.Linq; truy xuất dữ liệu 1 đối tượng trong danh sách theo id
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            ViewBag.accounts = account;
            return View();
        }
    }
}
