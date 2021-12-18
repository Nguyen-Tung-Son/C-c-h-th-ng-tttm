using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TS
{
    [Table("TinhNang")]
    public class TinhNang 

    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string TNId {get;set;}
        [Required, StringLength(50), Display(Name ="Tính năng")]
        public String TN {get;set;}
    }

}