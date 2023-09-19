namespace Lab02_2._1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Nhập tên thuê bao");
            string name = Console.ReadLine();
            
            Console.WriteLine("Nhập số điện thoại trên công tơ: ");
            int number = Convert.ToInt32(Console.ReadLine());

            double money = 0;
            //tính số tiền
            if(number <= 30) {
                money = 30;
            }
            else if(number > 30 && number <= 50)
            {
                money = 30 + (number - 30)  * 1.2;
            }
            else if (number > 50)
            {
                money = 30 + 20 * 1.2 + (number - 50) * 1.5;
            }
            Console.WriteLine("****Thông tin****");
            Console.WriteLine("Họ và tên: {0}", name);
            Console.WriteLine("Số điện sử dụng: {0}", number);
            Console.WriteLine("Tổng số tiền điện {0}", money);
        }
    }
}