internal class Program
{
    private static void Main(string[] args)
    {
        char Letter;
        Console.WriteLine("Nhập chữ cái");
        Letter = Convert.ToChar(Console.ReadLine());

        switch (Letter)
        {
            case 'u':
            case 'e':
            case 'o':
            case 'a':
            case 'i':
                Console.WriteLine("nguyên âm");
                break;
            default: Console.WriteLine("phụ âm");
                break;

        }
        
    }
}