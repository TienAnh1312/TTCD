using Lab6_3;

internal class Program
{
    private static void Main(string[] args)
    {
        // khai báo và khởi tạo danh sách sinh viên sử dựng List generic
        List<Student> list = new List<Student>()
        {
            new Student{Id="S10", FrirstName= "Nguyen Thu",LastName="Phuong",Avg=9.5},
            new Student{Id="S12", FrirstName= "Tran Thi",LastName="Thuy",Avg=8.2},
            new Student{Id="S13", FrirstName= "Le Hoang",LastName="Nhat",Avg=7.9},
            new Student{Id="S14", FrirstName= "Nguyen Van",LastName="Phong",Avg=6.7},
            new Student{Id="S15", FrirstName= "Hoang Thi",LastName="Hue",Avg=5.4},
            new Student{Id="S16", FrirstName= "Nguyen Tien",LastName="Tung",Avg=4.8},
            new Student{Id="S17", FrirstName= "Nguyen Thien",LastName="Nhan",Avg=4.7},

        };
        //in danh sách sinh viên
        Console.WriteLine("Danh sach sinh vien: ");
        foreach (var st in list)
        {
            Console.WriteLine(st);
        }
        // tìm sinh viên có điểm trung bình cao nhất
        double max = list[0].Avg;
        Student stmax = list[0];
        foreach (var st in list)
        {
            if (st.Avg > max)
            {
                max = st.Avg;
                stmax = st;
            }
        }
        //in kết quả
        Console.Write("Sinh vien co diem cao nhat la : ");
        Console.Write(stmax);

    }
}