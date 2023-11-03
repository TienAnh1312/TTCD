using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab05_demo.Models.ModelViews
{
    public class MemberView
    {
        public string MemberId { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage ="Tên đăng nhập không được để trống")]
        [StringLength(20,MinimumLength = 3, ErrorMessage ="Độ dài tên từ 3 - 20 ký tự")]
        public string UserName { get; set; }
        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        public string FullName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        public string PassWord { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Eamil không được bỏ trống")]
        [RegularExpression(@"[a-zA-z0-9._+-] +@[a-z0-9._]+\.[a-z]{2,4}$", ErrorMessage ="Email chưa đúng định dạng")]
        public string Email { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được bỏ trống")]
        [RegularExpression(@"^0\d{9,11}$", ErrorMessage = "Số điện thoại không đúng")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Birthday không được bỏ trống")]
        public DateTime? Birthday { get; set; }
    }
}
