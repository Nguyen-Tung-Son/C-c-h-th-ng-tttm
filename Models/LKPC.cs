using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TS
{
    [Table("LKPC")]
    public class LKPC 

    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string LKPCId {get;set;}
        [Required, StringLength(50), Display(Name ="Tên linh kiện")]
        public String LKPCName {get;set;}
    }

}