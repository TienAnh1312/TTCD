using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab08.Areas.Admin.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }

        //khóa ngoại tới bảng order
        public Orders Orders { get; set; }
        //Khóa ngoại tới bảng Customer
        public Product Product { get; set; }
    }
}
