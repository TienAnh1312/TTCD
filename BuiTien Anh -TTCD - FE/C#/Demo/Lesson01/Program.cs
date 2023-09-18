internal class Program
{
    private static void Main(string[] args)
    {
        //kiểu dữ liệu
        //Kiểu số nguyên: in, long, short, byte

        int number = 12;
        Console.WriteLine(number);

        //kiểu số thực: float, double, decimal
        //float: kiểu số thực có độ chính xác kém nhất
        //double: kiểu số thực có độ chính xác cao
        //decimal: kiểu số thực có độ chính xác cao nhất
        double mark = 2.5;
        Console.WriteLine(mark);

        //kiểu ký tự chuỗi
        //char: Kiểu dữ liệu unicode, có kích thước 16-bit
        //string: kiểu chuỗi ký tự
        string name = "TIenAnh";
        Console.WriteLine(name);

        //Liểu Logic
        //bool: trả về giá trị "true" hoặc "false"
        bool check = false;
        Console.WriteLine(check);

        //Kiểu ngày và thời gian
        //Datetime: Biểu diễn ngày và thời gian
        //TimeSpan: Biểu diễ một khoảng thời gian
        DateTime dateTA = new DateTime(2023, 9, 19);
        //Console.WriteLine(dateTA);
        Console.WriteLine(dateTA.ToString("dd-MM-yyyy"));

        //Đặt tên biến
        //các toán tử
        //số học
        int a =1; 
        int b = 2; 
        int c = a+b; 
        Console.WriteLine(c);

        //so sánh 
        bool d = a <b;
        Console.WriteLine(d);

        //Logic
        int e = 2;
        bool f = a < b && b == 0;
        Console.WriteLine(f);

        //Gán
        int g = 3;
        g += 3;
        Console.WriteLine(g);

        //tăng giảm
        int h = 4;
        int i = 5;

        h++;
        i--;
        Console.WriteLine(h);
        Console.WriteLine(i);

        //Nối chuỗi
        string str1 = "Tien";
        string str2 = "Anh";

        string result = str1 + str2;
        Console.WriteLine(result);

        //điều kiện
        int k = 1;
        int m = 2;

        string numberResult = (k < m) ? "k lon hơn m" : "k nho hơn m";
        Console.WriteLine(numberResult);
    }
}
