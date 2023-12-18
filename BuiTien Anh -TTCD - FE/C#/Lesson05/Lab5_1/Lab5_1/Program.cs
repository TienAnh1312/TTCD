internal class Program
{
    private static void Main(string[] args)
    {
        int[] m = { 5, 8, 4, 2, 6, 7 };

        //duyệt mảng và in dữ liệu
        Console.WriteLine("Các phần tử của mảng");
        for (int i = 0; i < m.Length; i++)
        {
            Console.WriteLine("{0}",m[i]);
        }

        //tìm phần tử lớn nhất
        int max = m[0];
        for (int i = 1; i < m.Length; i++)
        {
            if (max < m[i]);
            max = m[i];
        }
        Console.WriteLine("\nPhan tu lon nhat: " +  max);

        //kiểm tra mảng đối xứng không
        bool kt = true;
        for (int i = 0; i < m.Length / 2; i++) {
            if (m[i] != m[m.Length - 1 - i]) {
            kt = false; break;
            }
        }
        if (kt)

            Console.WriteLine("Mang doi xung");
        else
            Console.WriteLine("Mang khong doi xung");
    }
}