using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab06_5.Models
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string SubjectName { get; set; }
    }
}
