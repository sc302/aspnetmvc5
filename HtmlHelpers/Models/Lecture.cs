using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Models
{
    [Bind(Exclude = "LectureId")]
    public class Lecture
    {
        [HiddenInput(DisplayValue = false)]
        public int LectureId { get; set; }
        public string LectureName { get; set; }

        public bool IsOk { get; set; }
    }

    public class Ahmet
    {
        public int SelectedLecture { get; set; }
    }

}