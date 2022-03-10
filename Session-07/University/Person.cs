using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University {
    [Serializable]
    public class Person {

        public Guid PersonID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Person() {
            PersonID = Guid.NewGuid();
        }

    }
}
