using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Grade {

        public Guid GradeID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int ActualGrade {get; set; }

        public Grade(Guid StudentID, Guid CourseID)
        {
            GradeID = new Guid();
        }
    }
}
