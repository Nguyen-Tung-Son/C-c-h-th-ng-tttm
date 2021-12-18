using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TS
{
    [Table("HSX")]
    public class HSX 

    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string HSXId {get;set;}
        [Required, StringLength(50), Display(Name ="Tên hãng")]
        public String HSXs {get;set;}
    }

}