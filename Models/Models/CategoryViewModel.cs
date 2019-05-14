using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models.Models
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        [Display(Name ="Kategori Adi")]
        public string CategoryName { get; set; }

        [Display(Name ="Stok sayisi")]
        public int Stock { get; set; }
    }
}