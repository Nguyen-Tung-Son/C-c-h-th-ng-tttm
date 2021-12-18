using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TS
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentID {get;set;}
        public string StudentName {get; set;}
    }
}