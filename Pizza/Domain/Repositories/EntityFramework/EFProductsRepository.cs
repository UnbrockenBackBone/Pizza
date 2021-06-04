using Microsoft.EntityFrameworkCore;
using Pizza.Domain.Entities;
using Pizza.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain.Repositories.EntityFramework
{
    public class EFProductsRepository : IProductsRepository
    {
        private readonly PizzaDbContext context;
        public EFProductsRepository(PizzaDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> GetProducts()
        {
            return context.Products;
        }

        public Product GetProductsByCategoryName(string category)
        {
            return context.Products.FirstOrDefault(x => x.Category == category);
        }

        public Product GetProductsById(Guid id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }
        public void SaveProduct(Product entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;// объект будет добавлен как новый
            else
                context.Entry(entity).State = EntityState.Modified;// старый объект будет изменён
            context.SaveChanges();
        }
    }
}
