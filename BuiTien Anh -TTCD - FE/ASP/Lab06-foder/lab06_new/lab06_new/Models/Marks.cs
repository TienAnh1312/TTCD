using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab06_5.Models
{
    [Table("Mark")]
    public class Marks
    {
        [Key]
        [ForeignKey("Subjects")]
        public int SubjectId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public float Score { get; set; }
    }
}
