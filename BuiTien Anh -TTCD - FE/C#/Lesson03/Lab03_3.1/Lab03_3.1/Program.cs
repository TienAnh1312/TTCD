using Lab03_3._1;

internal class Program
{
    /// <summary>
    /// Khởi tạo đối tượng, truy cập các trường và phương  thức
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        //tạo đối tượng lớp car
        Car myCar  = new Car();
        // gán giá trị cho các trường đối tượng 
        myCar.make = "Toyota";
        myCar.model = "MR2";
        myCar.color = "Black";
        myCar.year = 2003;

        //Hiển thị thông tin đối tượng myCar
        Console.WriteLine("Thông tin chi tiết");
        Console.WriteLine("make: " + myCar.make);
        Console.WriteLine("Model: "+ myCar.model);
        Console.WriteLine("Color: "+ myCar.color);
        Console.WriteLine("Year: " + myCar.year);

        //gọi các phương thức
        myCar.start();
        myCar.stop();
    }
}