﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace lab05.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [
            Display(Name = "Họ và tên"),
            Required(ErrorMessage = "Họ và tên không được để trống"),
            MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự"),
            MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự")
        ]
        public string FullName { get; set; }
        [Display (Name = "Địa chỉ Email")]
        [Required(ErrorMessage = "Địa chỉ Email không được trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-.]?[0-9]{3}[-. ]?([0-9]{4})$", ErrorMessage ="Số điện thoại không đúng định dạng")]
        [Remote(action:"Verifyphone", controller:"Account")]
        [Required(ErrorMessage = "Số điện thoại không được trống")]
        public string Phone { get; set; }

        [Display(Name = "Địa chỉ thường trú")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35,ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")]
        public string Address { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Giới tính")]
        public string Gender { get; set; }

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Link Fb cá nhân")]
        [Required(ErrorMessage = "Link không được để trống")]
        [Url(ErrorMessage ="Url phải đúng định dạng bao gồm http hoặc https, tên miền VD: htttp://facebook.com/itvnsoft")]
        public string Facebook { get; set; }

    }
}
