using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DuLichBui.Models
{
    public class DangKiThanhVienModel
    {
        [Key]
        public long MaThanhVien { get; set; }

        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage ="Yêu cầu nhập tên đăng nhập")]
        public string TaiKhoan { get; set; }

        [Display(Name = "Mật khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu ít nhất 6 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        public string MatKhau { get; set; }

        
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("MatKhau", ErrorMessage = "Xác nhận mật khẩu không đúng.")]
        public string KiemTraMatKhau { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }


        public string GioiTinh { get; set; }


        public string AnhDaiDien { get; set; }
        [Required(ErrorMessage ="Yêu cầu nhập số điện thoại")]
        public int? SDT { get; set; }

        [StringLength(50)]
        public string QuocGia { get; set; }

        [StringLength(50)]
        public string ThanhPho { get; set; }

        public string DiaChi { get; set; }

        public string FaceBookLink { get; set; }

        public string MoTaBanThan { get; set; }

        
    }
}