using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace lab04_2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Họ và tên")]
        public string Name { get; set; }

        [Display(Name = "Giá")]
        public string Price { get; set; }

        [Display(Name = "Giá ht")]
        public string SalePrice { get; set; }

        [Display(Name = "Trạng thái")]
        public string status { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Ảnh sản phẩm")]
        public string Image { get; set; }

        [Display(Name = "Id danh mục")]
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}
