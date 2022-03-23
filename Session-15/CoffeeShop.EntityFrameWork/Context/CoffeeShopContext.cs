using CoffeeShop.EntityFrameWork.Configuration;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.EntityFrameWork {
    public class CoffeeShopContext : DbContext {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }   
        public DbSet<ProductCategory> ProductCategories { get; set; }   
        public DbSet<Employee> Emploees { get; set; }   
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionsLine { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new TransactionConfig());
            modelBuilder.ApplyConfiguration(new TransactionLineConfig());


        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            var connString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=DBSession-15; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            optionsBuilder.UseSqlServer(connString);
        }












    }
}