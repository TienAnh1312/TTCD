internal class Program
{
    private static void Main(string[] args)
    {
        //khai báo mảng
        byte[] a = new byte[5];
        //nhập mảng
        try
        {
            for (int i = 0; i<=5; i++)
            {
                Console.WriteLine("a[{0}]= ", i + 1);
                a[i] = Convert.ToByte(Console.ReadLine());
            }
        }catch (FormatException ex) {
            Console.WriteLine("Khong duoc nhap gia tri nam ngoa mien 0-255");
        }catch (IndexOutOfRangeException ex) {
            Console.WriteLine("Loi vuot qua pham vi cua mang");
        }
        //in mảng
        Console.WriteLine("Noi dung mang");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}", a[i]);
        }
    }
}