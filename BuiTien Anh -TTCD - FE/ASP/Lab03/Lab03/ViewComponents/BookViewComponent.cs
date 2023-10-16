using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {   
            var books = book.GetBookList();
            return View(books);
        }
    }
}
