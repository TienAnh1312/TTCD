using Lab04_5;

internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();
        Console.WriteLine("Calling myCar.Start()");
        myCar.Start();

        Console.WriteLine("Calling myCar.TurnLeft()");
        myCar.TurnLeft();

        Console.WriteLine("Calling myCar.TurnRight()");
        myCar.TurnRight();

        Console.WriteLine("Calling myCar.Accelerate()");
        myCar.Accelerate();
        Console.ReadLine();

    }
}