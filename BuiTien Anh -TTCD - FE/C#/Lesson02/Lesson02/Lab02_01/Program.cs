using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Nhập mã sinh viên");
        int Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhập tên sinh viên");
        string name = Console.ReadLine();

        Console.WriteLine("Nhập ngày tháng năm sinh: ");
        DateTime Birthday = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine("Nhập điểm môn 1: ");
        int mark1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập điểm môn 2: ");
        int mark2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập điểm môn 3: ");
        int mark3 = Convert.ToInt32(Console.ReadLine());

        int diemTb = (mark1 + mark2 + mark3 / 3);
        Console.WriteLine("------Thông tin sinh viên ------");
        Console.WriteLine("Mã sinh viên: {0}", Id);
        Console.WriteLine("Tên sinh viên: {0}", name);
        Console.WriteLine("Ngày tháng năm sinh: {0}", Birthday.ToString("dd-MM-yyyy"));
        Console.WriteLine("Điểm trung bình: {0} ", diemTb);
    }
}