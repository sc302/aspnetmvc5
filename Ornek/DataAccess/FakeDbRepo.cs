using Ornek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ornek.DataAccess
{
    public class FakeDbRepo
    {
        public IEnumerable<StudentViewModel> GetStudents()
        {
            return new List<StudentViewModel>()
            {
                new StudentViewModel(){StudentId=1,StudentName="ahmet",StudentNot=12,GectiKaldi=true},
                new StudentViewModel(){StudentId=2,StudentName="ali",StudentNot=11,GectiKaldi=false},
                new StudentViewModel(){StudentId=3,StudentName="veli",StudentNot=43,GectiKaldi=false},
                new StudentViewModel(){StudentId=4,StudentName="selim",StudentNot=34,GectiKaldi=false},
                new StudentViewModel(){StudentId=5,StudentName="medet",StudentNot=75,GectiKaldi=false},
            };
        }
    }
}