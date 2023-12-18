using Lab5_bt4;

internal class Program
{
    private static void Main(string[] args)
    {
        Department department = new Department("IT Departnemt", 3);

        Employee employee1 = new Employee(1,"DEV", 9);
        Employee employee2 = new Employee(2, "Master", 19);

        department[0] = employee1;
        department[1] = employee2;

        Console.WriteLine("Employ Detail");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Employ: {0}", i +1);
            department[i].Display();
            Console.WriteLine();
        }
    }
}