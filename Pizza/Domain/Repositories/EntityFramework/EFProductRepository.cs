using Pizza.Domain.Entities;
using Pizza.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain.Repositories.EntityFramework
{
    public class EFProductRepository : IProductRepository
    {
        private readonly PizzaDbContext context;
        public EFProductRepository(PizzaDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> GetProducts()
        {
            return context.Products;
        }

        public Product GetProductsByCategoryName(string category)
        {
            throw new NotImplementedException();
        }

        public Product GetProductsById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
