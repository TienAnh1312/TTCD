using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        //danh sách các cuốn sách
        public List<Book> GetBookList()
        {
            List<Book> book = new List<Book>()
            {
                 new Book()
                {
                    Id = 1,
                    Title = "Chí phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/Image/b1.jfif",
                    Price = 50000,
                    Sumary = "",
                    TotalPage = 250

                },
                  new Book()
                {
                    Id = 2,
                    Title = "Tiến Anh",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "/Image/b2.jfif",
                    Price = 60000,
                    Sumary = "",
                    TotalPage = 250

                },
                  new Book()
                {
                    Id = 3,
                    Title = "Chí phèo",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/Image/b3.jfif",
                    Price = 50000,
                    Sumary = "",
                    TotalPage = 250

                },
                     new Book()
                {
                    Id = 4,
                    Title = "Chí phèo",
                    AuthorId = 4,
                    GenreId = 4,
                    Image = "/Image/b4.jfif",
                    Price = 50000,
                    Sumary = "",
                    TotalPage = 250
                },
            };
            return book;
        } 

        // chi tiết cuốn sách theo Id
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        //SelectListItem Author 
        public List<SelectListItem> Author { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Nam Cao"},
            new SelectListItem {Value = "2", Text = "Ngô Tất tố"},
            new SelectListItem {Value = "3", Text = "Adamkhom"},
            new SelectListItem {Value = "4", Text = "Thiền Sư"},    
        };
        //SelectListitem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Truyện tranh"},
            new SelectListItem {Value = "2", Text = "Văn học đương đại"},
            new SelectListItem {Value = "3", Text = "Phật học phổ thông"},
            new SelectListItem {Value = "4", Text = "Truyện cười"},
        };
    }
}
