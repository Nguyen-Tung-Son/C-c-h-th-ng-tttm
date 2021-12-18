using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TS
{
    [Table("KieuKhachHang")]
    public class KieuKhachHang 

    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string KKHId {get;set;}
        [Required, StringLength(50), Display(Name ="Kiểu khách hàng")]
        public String KKH {get;set;}
    }

}