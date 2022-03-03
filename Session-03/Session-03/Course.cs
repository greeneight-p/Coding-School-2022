using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Course {

        public Guid CourseID{ get; }
        public string CourseCode { get; set; }
        public string CourseSubject { get; set; }

    

        public Course()
        {
            CourseID = Guid.NewGuid();
        }



    }
}
