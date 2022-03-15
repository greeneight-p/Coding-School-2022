using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University {
    public class Student : Person {


        public int RegNum { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public Student() {

        }
    }
}
