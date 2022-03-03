using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Professor : Person {

    

        public string ProfessorRank { get; set; }
        public Course[] ProfessorCourses { get; set; }
        public string ProfessorName { get; set; }


        public Professor()
        {
            
        }


        public void Teach(Guid courseID,DateTime datetime)
        {

        }


        public new void SetName(string name)
        {
            ProfessorName = name;

        }
        public new string GetName()
        {
            return "Dr " + ProfessorName;
        }
    }
}
