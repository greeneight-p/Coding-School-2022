using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    public class Transaction : BaseEntity {

        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal TotalPrice { get; set; }


        public List<TransactionLine> TransactionLines { get; set; }


        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee{ get; set; }



        
        public Transaction() {

        }

    }
}
