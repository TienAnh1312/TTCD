using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab06_5.Models
{
    [Table("StdClass")]
    public class StdClass
    {
        [Key]
        public int Id { get; set; }
        public string ClassName { get; set; }

        //thuộc tính quan hệ 
        public ICollection<Student> stdClasses { get; set; } = new List<Student>();
    }
}
