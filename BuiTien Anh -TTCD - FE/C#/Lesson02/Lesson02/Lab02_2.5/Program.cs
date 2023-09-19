// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 0; i <= 100; i++) {
            if( i % 2 ==0 && i % 3 != 0){
            sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}
