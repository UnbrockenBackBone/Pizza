using Pizza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain.Repositories.Abstract
{
    public interface IProductsRepository
    {
        IQueryable<Product> GetProducts();
        Product GetProductsById(Guid id);
        Product GetProductsByCategoryName(string category);
    }
}
