using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class University : Institude{

        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }   

        public Grade[] Grades { get; set; } 

        public Schedule[] ScheduleCourses { get; set; }


        public University(){
            Courses = new Course[20];
            Students = new Student[30];
            ScheduleCourses = new Schedule[60];

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

        public void  SetSchedule(Guid courseID, Guid professorID, DateTime dateTime)
        {
            //Schedule newScedule = new();
            //newScedule.CourseID = courseID;
            //newScedule.ProfessorID = professorID;
            //newScedule.Calendar = dateTime;

            //return newScedule;
        } 



    }
}
