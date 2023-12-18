using Lab5_4;

internal class Program
{
    private static void Main(string[] args)
    {
        // tạo đối tượng book 
        Book b = new Book("Programing with C#", 4);
        //nhập thông tin các chương
        b[0] = new Chapter("Chapter 1", "Introduction to C#");
        b[1] = new Chapter("Chapter 2", "DataType and Variable to C#");
        b[2] = new Chapter("Chapter 3", "Input or Output to C#");
        b[3] = new Chapter("Chapter 4", "Stamen to C#");
        //in thông tin sách
        Console.WriteLine("List of book:");
        Console.WriteLine(b.Name);
        //danh sách chương
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(b[i]);
        }
        //thông tin chương 3
        Console.WriteLine("Detail of chapter 3");
        Console.WriteLine(b["Chapter 3"]);
        Console.Read();
    }
}