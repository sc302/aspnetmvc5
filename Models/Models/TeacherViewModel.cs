using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models.Models
{
    public class TeacherViewModel
    {
        public int TeacherId { get; set; }

        [Display(Name = "Ögretmen Adı")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girin")]
        [MaxLength(6, ErrorMessage = "En fazla 6 karakter girebilirsiniz")]
        public string TeacherName { get; set; }

        [Display(Name = "e-posta")]
        [DataType(DataType.EmailAddress,ErrorMessage ="eposta yanlış")]
        public string Email { get; set; }

   
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
    }
}