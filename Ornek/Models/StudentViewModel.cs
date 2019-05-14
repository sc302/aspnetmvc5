using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ornek.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        [Display(Name ="Öğrenci Adı")]
        public string StudentName { get; set; }
        [Display(Name = "Öğrenci Notu")]
        public int StudentNot{ get; set; }

        [Display(Name = "Geçtimi?")]
        public bool GectiKaldi { get; set; }

    }
}