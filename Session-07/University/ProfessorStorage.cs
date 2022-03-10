using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University {

    
    public class ProfessorStorage {

        public Professor[] Professors { get; set; }

        public ProfessorStorage(int x) {
            Professors = new Professor[x];
        }

        public ProfessorStorage() {
        }
    }
}
