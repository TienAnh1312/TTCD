using System.Reflection;
using System.Text;

namespace Lab01_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding .UTF8;
            int id = 1;
            string phone = "0828345288";
            string name = "Tiến Anh";
            string address = "Tuyên Quang";
            string email = "buitienanh13122003@gmail.com";
            DateTime dateTA = new DateTime(2003, 12, 13);
  
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine(phone);
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(email);
            Console.WriteLine(dateTA.ToString("dd-MM-yyyy"));
        }
    }
}