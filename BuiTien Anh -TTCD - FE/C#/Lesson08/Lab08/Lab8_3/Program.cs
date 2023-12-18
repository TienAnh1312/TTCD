using Lab8_3;

internal class Program
{
    private static void Main(string[] args)
    {
        //khai báo chung
        int[] Number = { 9, 7, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
        string[] Words =
        {
            "Chỉ", "Trích", "phê", "phán", "người", "khác", "giống", "như", "con",
            "chim", "bồ", "câu", "đưa", "thư",
            "bao", "giờ", "cũng", "quay", "về", "nơi", "xuất", "phát",
        };
        List<Film> ListFilm = new List<Film>()
        {
            new Film{FilmId = "F01", FilmName = "Diep vien 007", Price = 120000 },
            new Film{FilmId = "F02", FilmName = "Tam quoc dien ngia", Price = 130000 },
            new Film{FilmId = "F03", FilmName = "Thieu lam truyen ky", Price = 160000 },
            new Film{FilmId = "F04", FilmName = "Nguoi nhen 2", Price = 100000 },
            new Film{FilmId = "F05", FilmName = "ngan hang tinh yeu", Price = 120000 },
            new Film{FilmId = "F06", FilmName = "Nguoi dep va quai vat", Price = 120000 },
            new Film{FilmId = "F07", FilmName = "Biet doi Sai Gon", Price = 120000 },
        };
        //Lọc các só chẵn
        IEnumerable<int> querynumber = Number.Where(n => n % 2 == 0);
        Show<int>(querynumber, "Loc cac so chan");

        //Loc các từ có độ dài > 4
        IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
        Show<string>(queryword, "Loc cac tu co do dai > 4: ");

        //Lấy các từ có tên bắt đầu bằng chữ T
        IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
        Show<string>(queryT, "Loc cac tu co ten bat dau bang chu t: ");

        //Lọc các số duy nhất trong các tạp số
        var uniqueNumber = Number.Distinct();
        Show<int>(uniqueNumber, "Loc cac so duy nhat trong tap cac so: ");

        //Đếm xem có bao nhiêu từ không trùng nhau
        var countDistinct = Words.Distinct().Count();
        Console.WriteLine("Dem xem co bao nhieu tu khong trung nhau: " + countDistinct);

        //Lấy 4 số đầu tiên trong dãy
        var fourNumber = Number.Take(4);
        Show<int>(fourNumber, "Lay 4 so dau tien trong day: ");
        //Lấy 2 từ đầu tiên trong câu
        var twoword = Words.Take(2);
        Show<string>(twoword, "Lay 2 tu dau tien trong cau: ");

        //Lấy những từ đầu tiên có chứa chữ t
        var searchword = Words.TakeWhile(w => w.Contains('t'));
        Show<string>(searchword, "Lay nhung tu dau tien co chua cu t: ");

        //sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá < 200000
        var queryfilm = ListFilm.OrderBy(f => f.Price)
        .Select(x => new { x.FilmId, x.FilmName, x.Price })
        .ToList().TakeWhile(t => t.Price < 200000);

        //bỏ qua 3 phần tử đầu tiên, lấy tất cả các phần tử còn lại
        var skipNumber = Number.Skip(3);
        Show<int>(skipNumber, "Bo qu 3 phan tu dau tien, lay tat ca cac phan tu con lai: ");

        //Bỏ qua 3 phim đầu tiên lấy 3 phim kết tiếp ( có thể áp dụng để phân trang)
        var skipTakeFilm = ListFilm.Skip(3).Take(3);
        Show<Film>(skipTakeFilm, "Bo qua 3 phim dau tien, lay 3 phim ke tiep: ");

        //sắp xêp giảm dần, sau đó lấy các phần tử <5
        var sortNumber = Number.OrderByDescending(x => x).SkipWhile(x => x > 5);
        Show<int>(sortNumber, "Sap xep giam dan, sau do lay cac phan tu < 5: ");
    }

        private static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
}