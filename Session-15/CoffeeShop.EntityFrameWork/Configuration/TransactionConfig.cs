using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Configuration {

    public class TransactionConfig : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {

            builder.ToTable("Transactions");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.TotalPrice).HasColumnType("decimal");
          

            builder.HasOne(transaction => transaction.Customer).WithOne(customer => customer.Transaction).HasForeignKey<Transaction>(transaction => transaction.CustomerID);
            builder.HasOne(transaction => transaction.Employee).WithOne(employee => employee.Transaction).HasForeignKey<Transaction>(transaction => transaction.EmployeeID);
            


        }
    }
}
