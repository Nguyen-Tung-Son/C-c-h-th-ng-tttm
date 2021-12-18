using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TS
{
    [Table("LinhKienPC")]
    public class LinhKienPC 

    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string LinhKienPCId {get;set;}
        [Required, StringLength(50), Display(Name ="Tên linh kiện")]
        public String LinhKienPCName {get;set;}
        
        [Required, StringLength(50), Display(Name ="Giá tiền")]
        public String Price {get;set;}

        [Required, StringLength(50), Display(Name ="Hãng sản xuất")]
        public String HSXs {get;set;}

        [Required, StringLength(50), Display(Name ="Kiểu")]
        public String type {get;set;}
    }

}