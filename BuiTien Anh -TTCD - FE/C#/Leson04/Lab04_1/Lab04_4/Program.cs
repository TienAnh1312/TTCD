using Lab04_4;

internal class Program
{   
    private static void Main(string[] args)
    {
        //tạo một nhân viên 
        IPerson staff = new Staff();
        object data = "Bui Tien Anh";
        //gọi các hành động
        staff.Insert(data);
        staff.Delete(data);
        staff.Update(data);
        staff.Display(data);
        //Tạo sinh viên
        IPerson student = new Student()
        {
            Id = "S10", Name = "AnhCH", Age = 20    
        };
        //hiển thị dữ liệu
        student.Display(student);
    }
}