using Lab6_1;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Tạo ArayLisst
        ArrayList inv = new ArrayList();
        //thêm phần tử vào danh sách
        inv.Add(new Product("A", 5.9, 3));
        inv.Add(new Product("B", 8.2, 2));
        inv.Add(new Product("C", 3.5, 4));
        inv.Add(new Product("D", 1.8, 8));
        //in ra danh sách phần tử
        Console.WriteLine("Product list: ");
        foreach (Product i in inv)
        {
            Console.WriteLine("  "+i);
        }
    }
}