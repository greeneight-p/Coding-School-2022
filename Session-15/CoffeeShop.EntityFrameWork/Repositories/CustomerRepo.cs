using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Repositories {

    public class CustomerRepo : IEntityRepo<Customer> {
        public async Task Create(Customer entity) {

            using var context = new CoffeeShopContext();
            context.Customers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            using var context = new CoffeeShopContext();
            var foundCustomer = context.Customers.SingleOrDefault(x => x.ID == id);
            if (foundCustomer is null) {
                return;
            }
            context.Customers.Remove(foundCustomer);
            await context.SaveChangesAsync();
        }

        public List<Customer> GetAll() {
            using var context = new CoffeeShopContext();

            return context.Customers.ToList();
        }

        public Customer? GetById(Guid id) {
            using var context = new CoffeeShopContext();
            return context.Customers.Where(x => x.ID == id).SingleOrDefault();

        }

        public async Task Update(Guid id, Customer entity) {
            using var context = new CoffeeShopContext();
            var foundCustomer = context.Customers.SingleOrDefault(x => x.ID == id);
            if (foundCustomer is null) {
                return;
            }
            foundCustomer.Code = entity.Code;
            foundCustomer.Description = entity.Description;
            await context.SaveChangesAsync();

        }
    }
}
