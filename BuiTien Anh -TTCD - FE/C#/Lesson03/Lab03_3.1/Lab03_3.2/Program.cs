using Lab03_3._2;

internal class Program
{
    private static void Main(string[] args)
    {
        //tạo đối tượng Contact với contructor  không tham số
        Contact ct1 = new Contact();
        //gán giá trị cho ct1
        ct1.Id = 1;
        ct1.Frirstname = "Bui Tien";
        ct1.Lastname = "Anh";
        ct1.Address = "Tuyen Quang";
        ct1.Phone = "0828345288";
        ct1.Email = "buitienanh13122003@gmial.com";
        //tạp đối tượng contact với contructor có tham số
        Contact ct2 = new Contact(5, "Bui Duy", "Tuan", "Tuyen Quang", "0912207900", "buiduytuan1962@gmail.com");
        //hiển thị
        ct1.Display();
        ct2.Display();
    }
}