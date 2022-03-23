using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EntityFrameWork.Repositories {
    internal class ProductRepo : IEntityRepo<Product> {
        public async Task Create(Product entity) {
            using var context = new CoffeeShopContext();
            context.Products.Add(entity);
            await context.SaveChangesAsync();

        }

        public async Task Delete(Guid id) {
            using var context = new CoffeeShopContext();
            var foundProduct = context.Products.SingleOrDefault(x => x.ID == id);
            if (foundProduct is null) {
                return;
            }
            context.Products.Remove(foundProduct);
            await context.SaveChangesAsync();
        }
        public List<Product> GetAll() {
            using var context = new CoffeeShopContext();
            return context.Products.ToList();

        }

        public Product? GetById(Guid id) {
            using var context = new CoffeeShopContext();
            return context.Products.SingleOrDefault(x=>x.ID == id);
        }

        public async Task Update(Guid id, Product entity) {
            using var context = new CoffeeShopContext();
            var foundProduct = context.Products.SingleOrDefault(x => x.ID == id);
            if (foundProduct is null) {
                return;
            }

            foundProduct = entity;
            await context.SaveChangesAsync();
        }
}
