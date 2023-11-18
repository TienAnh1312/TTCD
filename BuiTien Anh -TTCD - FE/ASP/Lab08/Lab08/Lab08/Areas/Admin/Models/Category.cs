using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab08.Areas.Admin.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name= "Tên")]
        public string Name { get; set; }

        [Display(Name = "Trạng thái")]
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Ảnh")]
        public string Image { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        //Danh sách sản phẩm theo danh mục
        public ICollection<Product> Products { get; set; }
    }
}
