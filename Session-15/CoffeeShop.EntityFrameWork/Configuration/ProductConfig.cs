using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Configuration {
    internal class ProductConfig : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.ToTable("Products");
            builder.HasKey("ID");
            builder.Property("Code").HasMaxLength(8);
            builder.Property("Description").HasMaxLength(20);
            
        }
    }
}
