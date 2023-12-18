using Store;

internal class Program
{
    private static void Main(string[] args)
    {
        //tạo mới nhà phân phối cung cấp đầy đủ namespace
        Supply.Manufacturer dealer = new Supply.Manufacturer();
        //gán giá trị
        dealer.Name = "Coca cola";
        dealer.Email = "cocacola@gmail.com";
        dealer.Phone = "0123456";
        //in thông tin
        Console.WriteLine("Dealer ifomation");
        Console.WriteLine("\t Name: " + dealer.Name);
        Console.WriteLine("\t Email: " + dealer.Email);
        Console.WriteLine("\t Phone: " + dealer.Phone);
        //tạo mới sản phẩm nằm trong namespace Store
        StoreItem si = new StoreItem();
        //gán giá trị
        si.ItemNo = 613508;
        si.ItemName = "Fanta";
        si.Price = 80.00M;
        //inthoong tin
        Console.WriteLine("Store Inventory");
        Console.WriteLine("\t Item #:    ");
        Console.WriteLine(si.ItemNo);
        Console.WriteLine("\t Item Name:  ");
        Console.WriteLine(si.ItemName);
        Console.WriteLine("\t Unit price: ");
        Console.WriteLine(si.Price);
    }
}