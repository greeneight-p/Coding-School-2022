using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Institude {

        public Guid InstitudeID { get; set; }   
        public string InstitudeName { get; set; }   
        public int InstitudeYearsOfService { get; set; }

        public Institude()
        {

        }


        public void SetName(string name)
        {
            InstitudeName=name;
        }

        public string GetName()
        {
            return InstitudeName;   
        }
    }
}
