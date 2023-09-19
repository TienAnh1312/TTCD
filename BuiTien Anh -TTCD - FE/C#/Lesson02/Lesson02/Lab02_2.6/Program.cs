internal class Program
{
    private static void Main(string[] args)
    {
        string[] name = { "Thang, Long, Hoa, Dao" };
        Console.WriteLine("Danh sach sinh vien");
        foreach(var n in name)
        {
            Console.WriteLine(n);
        }
    }
}