using Lab6_bt3;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        // khởi tạp danh sách
        List<Car> Carlisst = new List<Car>
        {
            new Car { Name = "Car 1", Color = "Red"},
            new Car { Name = "Car 1", Color = "Red"},
            new Car { Name = "Car 1", Color = "Red"},
            new Car { Name = "Car 1", Color = "Red"},
            new Car { Name = "Car 1", Color = "Red"},
            new Car { Name = "Car 1", Color = "Red"},
            new Car { Name = "Car 1", Color = "Red"},
        };
        Console.WriteLine("Nhập màu muốn xóa: ");
        string colorToDelete = Console.ReadLine();
        //xóa
        Carlisst.RemoveAll(car => car.color.ToLower)
    }
}