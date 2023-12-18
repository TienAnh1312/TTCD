namespace Lab4_2.Models
{
    public class DataLocal
    {
        public static List<Product> _product = new List<Product>()
        {
            new Product()
            {
                Id = 0, Name = "TÔI ĐÃ TÁI SINH THÀNH BÉ CÁO CỦA THẦN", Price="20.000vnđ", SalePrice = "10.000vnđ", Status = "Đang tiến hành",
                CreatedDate = Convert.ToDateTime("2003/12/13"), Image = "/Images/Avatar/toi-da-tai-sinh-thanh-be-cao-cua-than.jpg", CategoryId = 1, Description ="Công chúa của đế quốc Roahim đã bị sát hại bởi chính anh trai của mình. Cô đã chết và kèm theo tội danh có ý định giết cha của mình.\r\n“Gì chứ?”\r\nSau cái chết oan uổng đó, cô đã tái sinh vào một cuộc sống mới!\r\nMột cuộc sống thứ hai mà cô chưa bao giờ nghĩ đến, nhưng không phải có điều gì đó hơi kỳ lạ sao?\r\nNgười cai trị phương Bắc của đế quốc Roahim. Đại công tước Elharan, chủ sở hữu của dãy núi Idelbador và tường băng, ngay cả hoàng đế cũng phải tôn trọng anh ta…"
            },

            new Product()
            {
                 Id = 1, Name = "THÁNH NỮ ĐƯỢC ĐẠI CÔNG TƯỚC NHẬN NUÔI", Price="20.000vnđ", SalePrice = "10.000vnđ", Status = "Trị bách bệnh",
                CreatedDate = Convert.ToDateTime("2003/12/13"), Image = "/Images/Avatar/thanh-nu-duoc-dai-cong-tuoc-nhan-nuoi.jpg", CategoryId = 1, Description ="Nâu trắng sữa"
            },

            new Product()
            {
                Id = 2, Name = "ĐẠI LÃO TU TIÊN BẮT ĐẦU BẰNG TÂM TRÍ", Price="20.000vnđ", SalePrice = "10.000vnđ", Status = "Trị bách bệnh",
                CreatedDate = Convert.ToDateTime("2003/12/13"), Image = "/Images/Avatar/dai-lao-tu-tien-bat-dau-bang-tam-tri.jpg", CategoryId = 1, Description ="Nâu trắng sữa"
            },

            new Product()
            {
                Id = 3, Name = "TÔI THĂNG CẤP MỘT MÌNH SS2", Price="20.000vnđ", SalePrice = "10.000vnđ", Status = "Trị bách bệnh",
                CreatedDate = Convert.ToDateTime("2003/12/13"), Image = "/Images/Avatar/toi-thang-cap-mot-minh-ss2.jpg", CategoryId = 1, Description ="Nâu trắng sữa"
            },

            
        };

        //Getpeople: lấy danh sách dữ liệu product
        public static List<Product> Getproducts()
        {
            return _product;
        }

        //getpeopleById : Lấy đối tượng product theo id
        public static Product? GetProductById(int Id)
        {
            var product = _product.FirstOrDefault(x => x.Id == Id);
            return product;
        }
    }
}
