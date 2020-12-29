using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DuLichBui.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời Nhâp User Name")]
        public string Taikhoan { set; get; }


        [Required(ErrorMessage = "Mời Nhâp Password")]
        public string Matkhau { set; get; }

        public bool Nhomatkhau { set; get; }
    }
}