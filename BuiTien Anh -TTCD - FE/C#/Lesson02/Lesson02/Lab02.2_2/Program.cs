internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        int y;
        int day = 0;

        Console.WriteLine("Nhập số năm: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số tháng: ");
        y = Convert.ToInt32(Console.ReadLine());

        switch (y)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 10:
            case 12:
                day = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                day = 30; 
                break;
            case 2:
                day = 29;
                break;
            default:
                Console.WriteLine("Nhập sai tháng: ");
                break;
        }
        Console.WriteLine("Tháng {0} nam {1} có {2} ngày ", y, x, day);
    }
}