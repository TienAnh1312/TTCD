using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        // khởi tạp tập dữ liệu
        string[] data = {" To", " Ve", " hon", " thi", "nguoi", " se", " tro",
        " thanh", " ke"," thu","c ua "," ta", " Chiu"," nguoi"," thi"," nguoi",
        " se"," la"," ban"," cua"," ta"};

        //truy vấn dữ liệu
        IEnumerable<string> result1 = from m in data select m;
        //hiển thị kết quả 
        Console.WriteLine("Hen thi tat ca ket qua");
        foreach (var item in result1)
        {
            Console.Write(item + "");
        }
        //truy vấn theo diều kiện lấy các từ là  "nguoi"
        IEnumerable<string> result2 = from m in data where m.Equals("nguoi")
        select m;
        //hiển thị
        Console.WriteLine("\n Truy van theo dieu kien");
        foreach (var item in result2) 
        {
            Console.WriteLine(item + "");
        }
        //sắp xếp dữu liệu
        IEnumerable<string> result3 = from m in data orderby m select m;
        //ht
        Console.WriteLine("Hien thi tat ca ket qua sap xep");
        foreach (var item in result3)
        {
            Console.WriteLine(item + " ");
        }
        //lấy tập dữ liệu mới
        var result4 = from m in data select new { Thuong = m.ToLower(),
                                                   Hoa = m.ToUpper()};
        //ht
        Console.WriteLine("Chu Thuong va Hoa");
        foreach (var item in result4)
        {
            Console.WriteLine(item.Thuong + ":" + item.Hoa);
        }
    }
}