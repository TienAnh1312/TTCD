using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab08.Areas.Admin.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [Display(Name ="Họ và tên người nhận")]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ Email người nhận")]
        public string Email { get; set; }

        [Display(Name = "Địa chỉ người nhận")]
        public string Address { get; set; }

        [Display(Name = "Ngày đặt")]
        public DateTime CreatedDate { get; set; }
       
        //Khóa ngoại tới bảng Customer
        public Customer Customer { get; set; }
    }
}
