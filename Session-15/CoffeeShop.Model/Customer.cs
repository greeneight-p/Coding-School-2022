using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    public class Customer : BaseEntity {


        public string Code { get; set; }
        public string Description { get; set; }


        //1Transaction eksarate apo 1 customer
        public List<Transaction> Transactions{ get; set; }  

        public Customer() {

        }


        public Customer ShallowCopy() {
            return (Customer)MemberwiseClone();
        }
    }
}
