using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;

namespace TS
{
    [Table("GiaTien")]
    public class GiaTien 

    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string GiaTienId {get;set;}
        [Required, StringLength(50), Display(Name ="VNĐ")]
        public String GiaTiens {get;set;}
    }

}