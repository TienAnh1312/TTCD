using Lab04_3;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        //khởi tạo hình chữ nhật
        Lab04_3.Rectangle rec = new Lab04_3.Rectangle();
        //Nhập dữ liệu
        rec.InputData();
        //in thông tin
        Console.WriteLine("Dien tich hinh chu nhat la: {0:N}", rec.Area());
        Console.WriteLine("Chu Vi hinh chu nhat la: {0:N}", rec.Circumference());
        //khởi tạo hình tròn
        Circle cir = new Circle();
        //nhập dữ liệu
        cir.InputData();
        //inthoong tin
        Console.WriteLine("Dien tich hinh tron la: {0:N}", cir.Area());
        Console.WriteLine("Chu Vi hinh tron la: {0:N}", cir.Circumference());
    }
}