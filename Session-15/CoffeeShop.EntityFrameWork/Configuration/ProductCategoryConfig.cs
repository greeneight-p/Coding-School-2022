using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Configuration {
    public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory> {
        public void Configure(EntityTypeBuilder<ProductCategory> builder) {
            builder.ToTable("ProductCategories");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Code).HasMaxLength(8);
            builder.Property(x => x.Description).HasMaxLength(20);


            // 1 product exei 1 productCat 
            
    
        }
    }
}
