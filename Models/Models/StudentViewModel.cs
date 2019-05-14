using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }

       
        [Required(ErrorMessage ="Lutfen Ogrenci adi giriniz!")]
        [Display(Name ="Ögrenci Adı")]
        [MinLength(3,ErrorMessage ="En az 3 karakter girin")]
        [MaxLength(6,ErrorMessage ="En fazla 6 karakter girebilirsiniz")]
        public string StudentName { get; set; }
        //public bool IsPass { get; set; }

        [Required(ErrorMessage = "Ortalama deger girin")]
        [Display(Name = "Ortalama")]
        public int Avarage { get; set; }


        [Required(ErrorMessage = "e-posta girin")]
        [Display(Name = "e-posta")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "e-posta tekrar girin")]
        [Display(Name = "e-posta")]
        [Compare("Email",ErrorMessage ="eposta adresleri aynı değil")]
        [DataType(DataType.EmailAddress)]
        public string Email2 { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

    }
}