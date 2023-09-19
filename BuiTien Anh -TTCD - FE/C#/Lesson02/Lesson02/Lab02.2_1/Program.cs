namespace Lab02._2_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Nhập Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập tên: ");
            string name = Console.ReadLine();

            Console.WriteLine("Nhập địa chỉ: ");
            string address = Console.ReadLine();

            Console.WriteLine("Nhập ngày tháng năm sinh: ");
            DateTime Birthday = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Nhập lương: ");
            int Salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập tiền thưởng: ");
            int Bonus = Convert.ToInt32(Console.ReadLine());

            int TotalSalary = (Salary + Bonus);

            Console.WriteLine("------Thông tin------");
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Tên: {0}", name);
            Console.WriteLine("Địa chỉ: {0}", address);
            Console.WriteLine("Ngày tháng năm sinh: {0}", Birthday.ToString("dd-MM-yyyy"));
            Console.WriteLine("Lương: {0} ", Salary);
            Console.WriteLine("Thưởng: {0} ", Bonus);
            Console.WriteLine("ToltalSalary: {0}", TotalSalary);
        }
    }
}