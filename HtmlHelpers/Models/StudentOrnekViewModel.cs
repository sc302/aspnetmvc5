using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmlHelpers.Models
{
    public class StudentOrnekViewModel
    {
        public int StudentId { get; set; }

        [Display(Name ="Öğrenci Adı")]
        public string StudentName { get; set; }
        public bool IsPass { get; set; }
        public int Avarage { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}