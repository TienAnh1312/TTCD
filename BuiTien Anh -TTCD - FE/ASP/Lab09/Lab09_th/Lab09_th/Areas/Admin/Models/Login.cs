using System.ComponentModel.DataAnnotations;

namespace Lab09_th.Areas.Admin.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Hãy nhập Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
