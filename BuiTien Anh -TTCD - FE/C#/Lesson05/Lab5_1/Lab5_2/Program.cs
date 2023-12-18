internal class Program
{
    /// <summary>
    /// Chương trình minh họa thao tác trên mảng 2 chiều
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        // khai báo và khởi tạo mảng    
        int[,] a = {
            { 4, 6, 9 },
            { 2, 4, 5},
            { 9, 2, 6},
            { 1, 6, 3},
        };
        //duyệt mảng và in theo hàng cột
        Console.WriteLine("Noi dung mang");
        for (int i = 0; i <= a.GetUpperBound(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j <= a.GetUpperBound(1); j++)
            {
                Console.WriteLine("{0}", a[i , j]);
            }
            Console.WriteLine();
        }
        //tìm các phần tử có chỉ số hàng bằng chỉ số cột
        Console.WriteLine("Cac phan tu co chi so hang bang chi so cot");
        for (int i = 0; i <= a.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= a.GetUpperBound(1); j++)
            {
                if( i == j)
                    Console.WriteLine("{0}", a[i, j]);
            }
        }
        //tìm các phần tử lớn nhất trên hàng
        Console.WriteLine("Cac phan tu lon nhat tren hang");
        for (int i = 0; i <= a.GetUpperBound(0); i++)
        {
            int max = a[i, 0];
            for (int j = 0; j <= a.GetUpperBound(1); j++)
            {
                if (max < a[i,j])
                   max = a[i, j];
            }
            Console.WriteLine("Hang: {0}:{1}", i, max);
        }
    }
}