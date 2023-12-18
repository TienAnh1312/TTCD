using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // tạo một HashTable
        Hashtable weekDays = new Hashtable();

        // thêm các ngày trong tuần vào hashtable
        weekDays.Add(1, "Monday");
        weekDays.Add(2, "tuesday");
        weekDays.Add(3, "Wendesday");
        weekDays.Add(4, "Thursday");
        weekDays.Add(5, "Friday");
        weekDays.Add(6, "Saturday");
        weekDays.Add(7, "Sunday");

        //Nhập ngày cần tìm
        Console.WriteLine("Nhập ngày cần tìm: ");
        string daytoFind = Console.ReadLine();

        //kiểm tra xem ngày có tồn tại trong Hashtavle không
        if (weekDays.ContainsValue(daytoFind))
        {
            Console.WriteLine("Ngày {0} đã được tìm thấy", daytoFind);
        }
        else
        {
            Console.WriteLine("Không tìm thấy ngày {0}", daytoFind);
        }
        //in ra các ngày trong tuần bao gồm cả key và value
        Console.WriteLine("Các ngày trong tuần: ");
        foreach (DictionaryEntry weekDay in weekDays)
        {
            Console.WriteLine("Key: {0}, Value: {1}", weekDay.Key, weekDay.Value);
        }
    }
}