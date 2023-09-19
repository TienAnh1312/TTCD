using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int a, b, c;
        Console.WriteLine("Nhập a");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập b");
        b = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Nhập c");
        c = Convert.ToInt32(Console.ReadLine());

        //kiểm tra 3 cạnh có phải là 3 cạnh của tam giác không
        if( a<b+c && b<a+c && c<a+b)
        {
            if(a*a ==  b*b + c*c || b*b == a*a+c*c || c*c == a* a + b* b)
            {
                Console.WriteLine("Đây là tam giác vuông");
            }
            else if(a==b && b==c && c==a)
            {
                Console.WriteLine("Đây là tam giác đều");
            }
            else if (a==b || b==c || a==c)
            {
                Console.WriteLine("Đây là tam giác cân");
            }
            else if(a*a > b*b + c*c || b*b > a*a + c*c || c*c > a*a + b*b)
            {
                Console.WriteLine("Đây là tam giác tù");
            }
            else
            {
                Console.WriteLine("Đây là tam giác nhọn");
            }
        }
        else
        {
            Console.WriteLine("Ba cạnh a,b,c không phải là ba cạnh của tam giác");
        }

    }
}