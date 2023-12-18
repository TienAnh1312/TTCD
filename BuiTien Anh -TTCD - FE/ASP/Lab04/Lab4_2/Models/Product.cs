using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab4_2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }

        [Display(Name = "Giá")]
        public string Price { get; set; }

        [Display(Name = "Giảm giá")]
        public string SalePrice { get; set; }

        [Display(Name = "Trạng thái")]
        public string Status { get; set; }

        [Display(Name = "Cập nhập lúc: ")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Ảnh")]
        public string Image { get; set; }

        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }

        [Display(Name = "Giới thiệu")]
        public string Description { get; set; }

    }
}
