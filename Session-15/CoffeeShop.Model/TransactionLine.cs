using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    public class TransactionLine :BaseEntity {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }

        //TransactionLine eksartate apo 1 product
        public Product Product { get; set; }
        public Guid ProductID { get; set; }

       public Transaction Transaction { get; set; }
       public Guid TransactionID { get; set; }



        public TransactionLine() {

        }
    }
}
