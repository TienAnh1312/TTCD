using Business;

internal class Program
{
    private static void Main(string[] args)
    {
        //tạo mới đối tượng House trong namespace Bussiness
        Business.House h = new Business.House();

        //gán thông tin
        h.HouseNo = "D294FF";
        h.Price = 425880;
        //in thông tin
        Console.WriteLine("House details");
        Console.WriteLine("\t House No: " + h.HouseNo);
        Console.WriteLine("\t Price: " + h.Price);
        //tạo mới đối tượng car trong namespace 
        Business.Dealership.Car c = new Business.Dealership.Car();
        c.CarNo = "A0999";
        c.Price = 34825.50M;
        // in thông tin
        Console.WriteLine("Car detail");
        Console.WriteLine("\t Car No: " + h.HouseNo);
        Console.WriteLine("\t Price: " + h.Price);
    }
}