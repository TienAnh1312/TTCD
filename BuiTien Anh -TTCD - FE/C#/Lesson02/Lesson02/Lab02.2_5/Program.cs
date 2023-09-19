internal class Program
{
    private static void Main(string[] args)
    {
        //hinh 1
        for (int i = 0; i <= 10; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
        //hinh 2
        for (int i = 10; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine("");
        }
        //hinh3
        for (int i = 0; i <= 10; i++)
        {
            for (int j = i; j <= 10; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
    }
}