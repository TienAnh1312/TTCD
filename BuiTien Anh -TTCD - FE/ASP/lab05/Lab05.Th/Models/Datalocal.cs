namespace Lab05.Th.Models
{
    public class Datalocal
    {
        public static List<Category> _categories = new List<Category>()
        {
            new Category() { Id = 1, Name = "Truyện tranh", CreateDate = DateTime.Now, CreateBy="TienAnh", Status = true},
            new Category() { Id = 2, Name = "Truyện màu", CreateDate = DateTime.Now, CreateBy="TienAnh", Status = true},
            new Category() { Id = 3, Name = "Truyện chữ", CreateDate = DateTime.Now, CreateBy="TienAnh", Status = false},
        };
        public static List<Product> _products = new List<Product>()
{
            new Product(){
                Id=1,
                Name="ĐẠI LÃO TU TIÊN BẮT ĐẦU BẰNG TÂM CHÍ",
                Description="Trần Phong mang theo hệ thống thần cấp xuyên đến thế giới tu tiên, nhưng hắn không biết sự lớn mạnh của bản thân, vẫn luôn nghĩ bản thân là tên cùi bắp. Rốt cuộc để giữ hắn ở lại, người trong tông môn đều giả vờ bày ra vẻ hắn rất cùi bắp. Thế là một người có ngộ tính cực cao nhưng vẫn cho rằng mình rất phế sẽ nhấc lên phong vân như thế nào trong thế giới này đây!",
                Price=1200,
                SalePrice=1100,
                Image="/Images/products/dai-lao-tu-tien-bat-dau-bang-tam-tri.jpg",
                CreateDate=DateTime.Now,
                Status=true,
                CategoryId=1},
            new Product(){
                Id=2,
                Name="THÁNH NỮ ĐƯỢC ĐẠI CÔNG TƯỚC NHẬN NUÔI",
                Description="Tôi buộc phải sống trong cảnh giam cầm cho đến hết đời vì tôi tình cờ nhận ra rằng tôi là một vị thánh. Tôi thực sự là một vị thánh ‘thực sự’, nhưng điều đó không thành vấn đề, bởi vì đã có một vị thánh được chỉ định trong đền thờ.",
                Price=1200,
                SalePrice=1100,
                Image="/Images/products/thanh-nu-duoc-dai-cong-tuoc-nhan-nuoi.jpg",
                CreateDate=DateTime.Now,
                Status=false,
                CategoryId=2},
             new Product(){
                Id=3,
                Name="TÔI ĐÃ TÁI SINH THÀNH BE CÁO CỦA THẦN",
                Description="Công chúa của đế quốc Roahim đã bị sát hại bởi chính anh trai của mình. Cô đã chết và kèm theo tội danh có ý định giết cha của mình.",
                Price=1200,
                SalePrice=1100,
                Image="/Images/products/toi-da-tai-sinh-thanh-be-cao-cua-than.jpg",
                CreateDate=DateTime.Now,
                Status=true,
                CategoryId=3},
        };

    }
}
