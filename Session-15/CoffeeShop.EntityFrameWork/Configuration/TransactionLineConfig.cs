using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Configuration {
    internal class TransactionLineConfig : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            builder.ToTable("TransactionLines");
            builder.HasKey(x=> x.ID);
            builder.Property(x => x.Quantity).HasColumnType("int");
            builder.Property(x => x.Price).HasColumnType("decimal");
            builder.Property(x => x.Discount).HasColumnType("decimal");
            builder.Property(x => x.TotalPrice).HasColumnType("decimal");


            builder.HasOne(transline => transline.Product).WithOne(product => product.TransactionLine).HasForeignKey<TransactionLine>(tl => tl.ProductID);
            //builder.HasOne(tl=> tl.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(tl=>tl.TransactionID);




        }
    }
}
