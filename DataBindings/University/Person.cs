using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University {
    public class Person {

        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }   
        public int Age { get; set; }  
        

        public Person() {

        }





    }
}
