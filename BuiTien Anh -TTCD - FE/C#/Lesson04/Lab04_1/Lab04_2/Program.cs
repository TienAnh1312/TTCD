using Lab04_2;

internal class Program
{
    private static void Main(string[] args)
    {
        //khởi tạo sinh viên cao đẳng và in ra thông tin
        Console.WriteLine("Sinh vien Cao Dang: ");
        StudentCollege sv1 = new StudentCollege("Hanh", 2002, 9.5, 8, 7);
        sv1.Display();
        Console.WriteLine("Average of score: {0}", sv1.Average());
        //khởi tạo sinh viên đại học 
        Console.WriteLine("Sinh Vien Dai hoc: ");
        StudentUniversity sv2 = new StudentUniversity("Anh", 2003, 6, 8, 7, 9);
        sv2.Display();
        Console.WriteLine("Average of score: {0}", sv2.Average());
    }
}