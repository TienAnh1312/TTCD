using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab08.Areas.Admin.Models
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Status { get; set; }
        public int Prioty { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image {  get; set; }
        public string Description { get; set; }
    }
}
