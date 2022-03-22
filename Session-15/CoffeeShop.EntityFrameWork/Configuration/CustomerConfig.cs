using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Configuration {
    public class CustomerConfig : IEntityTypeConfiguration<Customer> {
        public void Configure(EntityTypeBuilder<Customer> builder) {

            builder.ToTable("Customers");
            builder.HasKey(b => b.ID);
            builder.Property(b => b.Code).HasMaxLength(8);
            builder.Property(b => b.Description).HasMaxLength(20);

        }
    }
}

