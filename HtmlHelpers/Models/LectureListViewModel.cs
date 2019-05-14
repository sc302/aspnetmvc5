using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Models
{
    public class LectureListViewModel
    {
        public SelectList Dersler { get; set; }
        public int SelectedLecture { get; set; }
    }
}