using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab06_5.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Tên học sinh")]                
        public string StudentName { get; set; }

        [Display(Name = "Email")]
        public string StudentEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        public string StudentPhone { get; set; }

        [Display(Name = "Địa chỉ")]
        public string StudentAddress { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string StudentAvartar { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime StudentBirthday { get; set; }

        [ForeignKey("StdClass")]
        [Display(Name = "Mã lớp")]
        public int? ClassId { get; set; }
        //tạo quan hệ rằng buộc - category
        public virtual StdClass? StdClass { get; set; }

        
    }
}