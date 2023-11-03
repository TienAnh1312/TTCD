using System.ComponentModel.DataAnnotations;

namespace Lab05.Th.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Hãy nhập ID")]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Tên sản phẩm phải ít nhất 6 ký tự và không quá 150 ký tự")]
        [Display(Name = "Tên")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập mô tả")]
        [StringLength(1500, ErrorMessage = "Mô tả không vượt quá 1550 ký tự")]
        [RegularExpression(@"^(?!.*\b(die|admin|fuck|shit|cunt)\b).*$", ErrorMessage ="mô tả không được chứa các ký tự nhạy cảm")]
        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập giá sản phẩm")]
        [Range(100000, double.MaxValue, ErrorMessage = "Giá sản phẩm phải lớn hơn hoặc bằng 100,000")]
        [DataType(DataType.Currency)]
        [Display(Name = "Giá")]
        public float? Price { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập giá khuyến mãi")]
        //[Range(0, 0.1, ErrorMessage = "Giá khuyến mãi không âm và nhỏ hơn 10% giá chuẩn")]
        [Display(Name = "Giá khuyến mãi")]
        public float? SalePrice { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn hình ảnh")]    
        [Display(Name = "Hình ảnh")]
        public string? Image { get; set; }

        [Required(ErrorMessage = "Bạn phải chọn danh mục")]
        [Range(1,int.MaxValue, ErrorMessage = "CategoryId không hợp lệ")]
        [Display(Name = "CategoryID")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập ngày tháng")]
        public DateTime CreateDate { get; set; }
        public string? CreateBy { get; set; }

        [Required(ErrorMessage = "bạn phải nhập trạng thái")]
        public bool? Status { get; set; }

        //tạo quan hệ rằng buộc - category
        public virtual Category? Category { get; set; }
    }
}
