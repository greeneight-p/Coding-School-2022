using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Professor : Person {


        private string _professorName;
        public string ProfessorRank { get; set; }
        public Course[] ProfessorCourses { get; set; }
        public string ProfessorName { get { return "Dr " + _professorName; } set { _professorName = value; } }


        public Professor()
        {
            
        }


        public void Teach(Guid courseID,DateTime datetime)
        {

        }


        //public new void SetName(string name)
        //{
        //    ProfessorName = name;

        //}
        //public new string GetName()
        //{
        //    return "Dr " + ProfessorName;
        //}
    }
}
