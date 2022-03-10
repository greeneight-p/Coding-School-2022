using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University {
    [Serializable]
    internal class Student : Person {

        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }

        public Student() {

        }




    }

}
