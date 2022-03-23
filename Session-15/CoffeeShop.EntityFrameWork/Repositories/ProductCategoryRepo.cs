using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;


namespace CoffeeShop.EntityFrameWork.Repositories {
    public class ProductCategoryRepo : IEntityRepo<ProductCategory> {
        public async Task Create(ProductCategory entity) {
            using var context = new CoffeeShopContext();
            context.ProductCategories.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            using var context = new CoffeeShopContext();
            var foundProductCat = context.ProductCategories.SingleOrDefault(x => x.ID == id);
            if (foundProductCat is null) {
                return;
            }
            context.ProductCategories.Remove(foundProductCat);
            await context.SaveChangesAsync();
        }

        public List<ProductCategory> GetAll() {
            using var context = new CoffeeShopContext();
            return context.ProductCategories.ToList();

        }

        public ProductCategory? GetById(Guid id) {
            using var context = new CoffeeShopContext();
            return context.ProductCategories.Where(x => x.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, ProductCategory entity) {
            using var context = new CoffeeShopContext();
            var foundProductCat = context.ProductCategories.SingleOrDefault(x => x.ID == id);
            if (foundProductCat is null) {
                return;
            }
            foundProductCat.Code = entity.Code;
            foundProductCat.Description = entity.Description;
            foundProductCat.ProductType = entity.ProductType;
            await context.SaveChangesAsync();


        }
    }
}
