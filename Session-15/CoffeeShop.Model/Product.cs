using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    public class Product : BaseEntity {

        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        //Relation - Product eksartate apo 1 productCAt
        public Guid ProductCategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }


        // Relation - kathe transline eksartate apo ena product
        public List<TransactionLine> TransactionLines { get; set; }





        public Product() {

        }

    }
}
