internal class Program
{
    private static void Main(string[] args)
    {
        bool check_i;
        Console.WriteLine("Dnah sách các số nguyên tố từ  2-100");

        //duyệt từ 2-100
        for(int i = 2; i<=100; i++)
        {
            check_i = true;//giả sử i là nguyên tố
            for(int j = 2; j<=i / 2; j++)//duyệt từ 2-j/2
            {
                if(i % j == 0)//nếu i chia hết cho j thì
                {
                    check_i = false;//kết luận không là số nguyên tố
                    break;
                }
            }
            if(check_i)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}