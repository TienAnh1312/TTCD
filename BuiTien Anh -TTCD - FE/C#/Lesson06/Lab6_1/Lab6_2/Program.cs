internal class Program
{
    private static void Main(string[] args)
    {
        //Tọa Sortedlist generic
        SortedList<string, string> listEm = new SortedList<string, string>();
        //đưau dữ liệu vào
        listEm.Add("E01", "Tran Thi Thuy");
        listEm.Add("E02", "Le Hai Ha");
        listEm.Add("E03", "Nguyen Van Hung");
        listEm.Add("E04", "Hoang Thi Thom");
        listEm.Add("E05", "Trinh Van Chien");
        //in  danh sách
        Console.WriteLine("Danh sach nhan vien");
        foreach (var key in listEm.Keys )
        {
            Console.WriteLine(key + ":" + listEm[key]);
        }
        //tìm kiếm tất cả các nhân viên có tên bắt đầu bằng chữ Th
        Console.WriteLine("Danh sách nhan vien bat dau bang chu Th");
        foreach (var key in listEm.Keys)
        {
            if (listEm[key].StartsWith("Th"))
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
        }
        //xóa nhân viên có mã E04
        listEm.Remove("E04");
        //kiểm tra nếu chưa có nhân viên E06 thì thêm vào
        if (!listEm.ContainsKey("E06"))
        {
            listEm.Add("E06", "Nguyen Hoai Linh");
        }
        // in danh sách sau khi xóa , thêm
        foreach (var key in listEm.Keys)
        {
            Console.WriteLine(key + ":" + listEm[key]);
        }
    }
}