using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    public class ProductCategory : BaseEntity {

        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }


        //Relation Product has 1 ProductCat
        public Product Product { get; set; }




        public ProductCategory() {

        }


        public ProductCategory ShallowCopy() {
            return (ProductCategory)MemberwiseClone();
        }


    }
}
