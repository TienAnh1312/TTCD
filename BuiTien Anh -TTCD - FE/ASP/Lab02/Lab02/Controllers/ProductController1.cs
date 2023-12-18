using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class ProductController1 : Controller
    {

            public IActionResult Index()
            {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,Name = "Củ cà rốt",
                    Avatar = Url.Content("~/Avatar/01.jpg"),
                    Price = "35000đ",
                    Bio ="Cuốn vào giải trí với  \\\"Tháng phim đỉnh - Siêu kịch tính\\\" cùng K+\\r\\n🎬 Chìm đắm trong những trải nghiệm gay cấn với các bộ phim siêu phẩm:  Cuộc chiến sinh tồn (The Escape of The Seven), Tết ở Làng Địa Ngục sớm nhất trên K+\"",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
                new Product()
                {
                    Id = 2,Name = "Gấu bông",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Price = "40000đ",
                    Bio ="Hàng mới chất lượng cao",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
                new Product()
                {
                    Id = 1,Name = "Củ cà rốt",
                    Avatar = Url.Content("~/Avatar/01.jpg"),
                    Price = "35000đ",
                    Bio ="Cuốn vào giải trí với  \\\"Tháng phim đỉnh - Siêu kịch tính\\\" cùng K+\\r\\n🎬 Chìm đắm trong những trải nghiệm gay cấn với các bộ phim siêu phẩm:  Cuộc chiến sinh tồn (The Escape of The Seven), Tết ở Làng Địa Ngục sớm nhất trên K+\"",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
                 new Product()
                {
                    Id = 1,Name = "Củ cà rốt",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Price = "35000đ",
                    Bio ="Hàng mới chất lượng cao",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
                 new Product()
                {
                    Id = 1,Name = "Củ cà rốt",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Price = "35000đ",
                    Bio ="Hàng mới chất lượng cao",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
                 new Product()
                {
                    Id = 1,Name = "Củ cà rốt",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Price = "35000đ",
                    Bio ="Hàng mới chất lượng cao",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
            };

            //gửi đối tượng account qua view
            ViewBag.Products = products;
            return View();
            }
            //định nghĩa url và nam cho action
            [Route("chi-tiet-san-pham", Name = "product")]
            public IActionResult ProfileProduct(int id)
            {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,Name = "Củ cà rốt",
                    Avatar = Url.Content("~/Avatar/01.jpg"),
                    Price = "35000đ",
                    Bio ="Cuốn vào giải trí với  \"Tháng phim đỉnh - Siêu kịch tính\" cùng K+\r\n🎬 Chìm đắm trong những trải nghiệm gay cấn với các bộ phim siêu phẩm:  Cuộc chiến sinh tồn (The Escape of The Seven), Tết ở Làng Địa Ngục sớm nhất trên K+",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
                new Product()
                {
                    Id = 2,Name = "Gấu bông",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Price = "40000đ",
                    Bio ="Hàng mới chất lượng cao",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
                new Product()
                {
                    Id = 3,Name = "Củ cà rốt",
                    Avatar = Url.Content("~/Avatar/01.jpg"),
                    Price = "35000đ",
                    Bio ="Cuốn vào giải trí với  \\\"Tháng phim đỉnh - Siêu kịch tính\\\" cùng K+\\r\\n🎬 Chìm đắm trong những trải nghiệm gay cấn với các bộ phim siêu phẩm:  Cuộc chiến sinh tồn (The Escape of The Seven), Tết ở Làng Địa Ngục sớm nhất trên K+\"",
                    Status = "Còn hàng",
                    Birthday = new DateTime(2021, 7, 15)
                },
            };

                //sử dụng using.Linq; truy xuất dữ liệu 1 đối tượng trong danh sách theo id
                Product product = products.FirstOrDefault(ac => ac.Id == id);
                ViewBag.products = product;
                return View();
            }
        }
    }
