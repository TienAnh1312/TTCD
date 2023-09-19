using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //string a = "17";
        //string b = "16";

        //int c = Convert.ToInt32((string)a);
        //int d = Convert.ToInt32((string)b);

        //Console.WriteLine(c + d);

        Console.OutputEncoding = Encoding.UTF8;
        //Console.WriteLine("Nhập giá trị a");
        //int a = Convert.ToInt32(Console.ReadLine());
        //if(a % 2 ==0)
        //{
        //    Console.WriteLine("a là số chẵn");
        //}
        //else if(a % 3 == 0)
        //{
        //    Console.WriteLine("a chia hết cho 3");
        //}else if(a % 4 == 0)
        //{
        //    Console.WriteLine("a chia hết cho 4");
        //}
        //else
        //{
        //    Console.WriteLine("a !");
        //}    

        //Console.WriteLine("Nhập tháng");
        //int month = Convert.ToInt32(Console.ReadLine());
        // for
        // khi bạn biết trước số lần lặp cụ thể

        //for (int i = 1; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //do while
        // lặp từng phần tử trong một tập hợp
        //string[] names= { "Tien", "Anh", "CH" };
        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        //lồng nhau
        for(int i = 1; i <= 10; i++) {
            Console.WriteLine(i);
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }
        }
    }
}