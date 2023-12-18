using Lab6_bt1;
using System.Globalization;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // tọa danh sách
        List<Book> booklist = new List<Book>()
        {
            new Book(){Id = 1, Title="Số đỏ" , Author="Vũ Trọng Phụng", Publisher="Nhà xuất bản trẻ", year= 1936, Price= 45000},
            new Book(){Id = 2, Title="Tắt đèn" , Author="Ngô Tất Tố", Publisher="Nhà xuất bản Văn Học", year= 1946, Price= 50000},
            new Book(){Id = 3, Title="Chiếc lá cuốn bay" , Author="Nguyễn Nhặt Ánh", Publisher="Nhà xuất bản trẻ", year= 1996, Price= 35000},
            new Book(){Id = 4, Title="Đất rừng phương nam" , Author="Nguyễn Thu Hương", Publisher="Nhà xuất bản Văn Học", year= 1988, Price= 55000},
            new Book(){Id = 5, Title="Dế mèn phiêu lưu ký" , Author="Tô Hoài", Publisher="Nhà xuất bản Kim Đồng", year= 1973, Price= 45000},
            new Book(){Id = 6, Title="Lão Hạc" , Author="Nam Cao", Publisher="Nhà xuất bản Văn Học", year= 1945, Price= 40000},
            new Book(){Id = 7, Title="Tắt đèn" , Author="nguyễn Quang Sáng", Publisher="Nhà xuất bản Văn Học", year= 1936, Price= 45000},
            new Book(){Id = 8, Title="Bên khung trời" , Author="Nguyễn Ngọc Thuần", Publisher="Nhà xuất bản trẻ", year= 2006, Price= 65000},
            new Book(){Id = 9, Title="Bên Sợi dây đàn" , Author="Bùi Tiến Anh", Publisher="Nhà xuất bản Kim Đồng", year= 1994, Price= 100000},
            new Book(){Id = 10, Title="Mắt biếc" , Author="Vũ Tiến", Publisher="Nhà xuất bản Văn học", year= 1926, Price= 95000},
        };
        //in danh sách tăng dần theo giá
        Console.WriteLine("Danh sách tăng dần theo giá");
        List<Book> sorteByPrice = booklist.OrderBy(book=>book.Price).ToList();
        foreach (var book in sorteByPrice)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Year: {book.year}, Price: {book.Price}");
        }

        // tìm sách tho tiltle
        Console.WriteLine("Nhập tiltle của quyển sách muốn tìm: ");
        string seachTille = Console.ReadLine();
        Book foundBook = booklist.Find(book => string.Compare(book.Title, seachTille, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase)==0);
        if (foundBook != null )
        {
            Console.WriteLine("Quyển sách đc tìm thấy");
            Console.WriteLine($"Title: {foundBook.Title}, Author: {foundBook.Author}, Publisher: {foundBook.Publisher}, Year: {foundBook.year}, Price: {foundBook.Price}");
        }
        else
        {
            Console.WriteLine("Không tìm thấy quyển sách nào");
        }
        //đưa ra màn sách xuất bản năm 2014
        Console.WriteLine("Nhập năm xuất bản muốn tìm");
        int seachYear = Convert.ToInt32(Console.ReadLine());
        List<Book> booksByYear = booklist.FindAll(book => book.year == seachYear);
        if (booksByYear.Count > 0)
        {
            Console.WriteLine($"Các quyển sách được xuất bản vào năm {seachYear}: ");
            foreach (var book in booksByYear)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Year: {book.year}, Price: {book.Price}");
            }
        }
        else
        {
            Console.WriteLine("Không tìm thấy quyển sách nào");
        }
        //xóa nhưng quyển sách của nhà xuất bản kim dồng
        Console.WriteLine("Nhập nhà xuất bản bạn muốn xóa: ");
        string publisherDeleted = Console.ReadLine();
        int bookRemoved = booklist.RemoveAll(book => string.Compare(book.Publisher, publisherDeleted, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase) == 0);
        Console.WriteLine($"Đã xóa {bookRemoved} quyển sách của nhà xuất bản {publisherDeleted}");
        Console.WriteLine("Danh sách sau khi xóa ");
        foreach (var book in booklist)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Year: {book.year}, Price: {book.Price}");
        }
    }
}