using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            //danh sách convert SelectListItem để hiển thị trin combobox
            ViewBag.author = book.Author; //truyền dữ liệu SelectListItem qua view
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books); //truyền dữ liệu qua view dưới dạng tham số
        }
        public IActionResult Create()
        {
            ViewBag.authors = book.Author;
            ViewBag.Genres = book.Genres;
            Book model = new Book();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.authors = book.Author;
            ViewBag.Genres = book.Genres;
            Book model = book.GetBookById(id);//lấy dữu liệu 1 cuốn sách theo id
            return View(model);
        }
        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }
    }
}