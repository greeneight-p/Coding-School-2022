using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Person {

        public int PersonAge { get; set; }
        public string PersonName { get; set; }
        public Guid PersonID { get; }
      



        public Person(){

            PersonID = Guid.NewGuid();


        }


        public string GetName()
        {
            return PersonName;
        }



        public void SetName(string name)
        {
            PersonName = name;

        }






    }


}
