using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelpers.Models
{
    public class Lecture
    {
        public int LectureId { get; set; }
        public string LectureName { get; set; }

        public bool IsOk { get; set; }
    }

    public class Ahmet
    {
        public int SelectedLecture { get; set; }
    }

}