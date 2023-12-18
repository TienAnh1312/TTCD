using Lab8_bt1;

internal class Program
{
    private static void Main(string[] args)
    {
        Book[] books = new Book[]
        {
            new Book{Id = 1 ,Name = "Book1" , Author = "Author 1", Price = 1200 , Publisher= "Nha xuat ban giao duc", Year= 2003  },
            new Book{Id = 2 ,Name = "Book2" , Author = "Author 2", Price = 900 , Publisher= "TienANh1", Year= 2004  },
            new Book{Id = 3 ,Name = "Book3" , Author = "Author 3", Price = 1400 , Publisher= "TienANh2", Year= 2005  },
            new Book{Id = 4 ,Name = "Book4" , Author = "Author 4", Price = 1500 , Publisher= "TienANh3", Year= 2006  },
            new Book{Id = 5 ,Name = "Book5" , Author = "Author 5", Price = 1600 , Publisher= "TienANh4", Year= 2015  },
            new Book{Id = 6 ,Name = "Book6" , Author = "Author 6", Price = 1700 , Publisher= "TienANh5", Year= 2008  },
            new Book{Id = 7 ,Name = "Lap trinh" , Author = "Author 6", Price = 1800 , Publisher= "TienANh6", Year= 2009  }
        };
        //ht
        Console.WriteLine("Tat ca sach :");
        foreach (var book in books)
        {
            Console.WriteLine("iD: {0}, Name: {1}, Author: {2}, Price: {3}, Publisher: {4}, Year: {5}", book.Id, book.Name, book.Author, book.Price, book.Publisher, book.Year);
        }
        //ht sách giá trị 1000-5000
        Console.WriteLine("Sach gia tri 1000-5000 la: ");
        var bookInRage = books.Where(book => book.Price >= 1000 && book.Price <= 5000);
        foreach (var book in bookInRage)
        {
            Console.WriteLine("iD: {0}, Name: {1}, Author: {2}, Price: {3}, Publisher: {4}, Year: {5}", book.Id, book.Name, book.Author, book.Price, book.Publisher, book.Year);
        }

        //ht sách xb năm 2015
        Console.WriteLine("Sach xuat ban nam 2015 la: ");
        var bookPublished = books.Where(book => book.Year == 2015);
        foreach (var book in bookPublished)
        {
            Console.WriteLine("iD: {0}, Name: {1}, Author: {2}, Price: {3}, Publisher: {4}, Year: {5}", book.Id, book.Name, book.Author, book.Price, book.Publisher, book.Year);
        }
        //ht sách có tên lập trình
        Console.WriteLine("Sach co ten lap trinh: ");
        var bookName = books.Where(book => book.Name == "Lap trinh");
        foreach (var book in bookName)
        {
            Console.WriteLine("iD: {0}, Name: {1}, Author: {2}, Price: {3}, Publisher: {4}, Year: {5}", book.Id, book.Name, book.Author, book.Price, book.Publisher, book.Year);
        }

        //Đếm sô sách nhà xb giáo dục
        Console.WriteLine("so sach nha xuat ban giao duc la: ");
        var Numberbook = books.Count(book => book.Publisher == "Nha xuat ban giao duc");     
        Console.WriteLine(Numberbook);       
    }
}