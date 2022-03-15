using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University {
    public class Course {

        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Code { get; set; } 
        public string Subject { get; set; }

        public Course() {

        }

    }
}
