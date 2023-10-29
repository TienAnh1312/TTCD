using System.ComponentModel.DataAnnotations;

namespace Lab04.TH.Models
{
    public class Category
    {
        
        public int Id { get; set; }

        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Tạo bởi")]
        public string CreateBy { get; set; }

        [Display(Name = "Trạng thái")]
        public bool Status { get; set;}
        
        //thuộc tính quan hệ 
        public ICollection<Product> Products { get; set;} = new List<Product>();
    }
}
