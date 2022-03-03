using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class University {

        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }   

        public Grade[] Grades { get; set; } 

        public Schedule[] ScheduleCourses { get; set; }


        public University(){


        }



        public Student[] GetStudents()
        {
            return Students;
        }


        public Course[] GetCourses()
        {
            return Courses;
        }

        public Grade[] GetGrades()
        {
            return Grades;
        }

        public void SetSchedule(Guid courseID, Guid ProfessorID)
        {

        }



    }
}
