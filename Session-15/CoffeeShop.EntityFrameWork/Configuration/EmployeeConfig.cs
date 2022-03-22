using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Configuration {
    public class EmployeeConfig : IEntityTypeConfiguration<Employee> {
        public void Configure(EntityTypeBuilder<Employee> builder) {
            builder.ToTable("Employees");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).HasMaxLength(15);
            builder.Property(x => x.Surname).HasMaxLength(25);
            builder.Property(x => x.SalaryPerMonth).HasColumnType("decimal");

        }
    }
}
