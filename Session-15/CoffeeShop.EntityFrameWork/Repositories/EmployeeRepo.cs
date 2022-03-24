using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Repositories {
    public class EmployeeRepo : IEntityRepo<Employee> {
        public async Task Create(Employee entity) {
            using var context = new CoffeeShopContext();
            context.Employees.Add(entity);
            await context.SaveChangesAsync();

        }

        public async Task Delete(Guid id) {
            using var context = new CoffeeShopContext();
            var foundEmployee = context.Employees.SingleOrDefault(x => x.ID == id);
            if (foundEmployee is null) {
                return;
            }
            context.Employees.Remove(foundEmployee);
            await context.SaveChangesAsync();

        }

        public List<Employee> GetAll() {
            using var context = new CoffeeShopContext();
            return context.Employees.ToList();
        }

        public Employee? GetById(Guid id) {
            using var context = new CoffeeShopContext();
            return context.Employees.SingleOrDefault(x => x.ID == id);

        }

        public async Task Update(Guid id, Employee entity) {
            using var context = new CoffeeShopContext();
            var foundEmployee = context.Employees.SingleOrDefault(x => x.ID == id);
            if (foundEmployee is null) {
                return;
            }
            foundEmployee = entity;
            await context.SaveChangesAsync();
        }
    }
}
