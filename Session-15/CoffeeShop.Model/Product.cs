using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model {
    public class Product {

        public Guid guid { get; set; } = Guid.NewGuid();
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid ProductCategory { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public Product() {

        }

    }
}
