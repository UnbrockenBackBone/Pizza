using System;
using System.Collections.Generic;
using Pizza.Domain.Repositories.Abstract;
using System.Linq;
using System.Threading.Tasks;
using Pizza.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Pizza.Domain.Repositories.EntityFramework
{
    public class EFUserProductsRepository : IUserProductsRepository
    {
        private readonly PizzaDbContext context;
        public EFUserProductsRepository(PizzaDbContext context)
        {
            this.context = context;
        }
        public List<Product> GetByUserId(Guid id)
        {
            List<Product> products = new();

            var userProducts = context.UserProducts.Where(x => x.IdUser == id);

            foreach (UserProducts user in userProducts)
            {
                products.Add(context.Products.FirstOrDefault(x => x.Id == user.IdProduct));
            }

            return products;
        }

        public void SaveProduct(UserProducts product)
        {

            if (product.Id == default)
                context.Entry(product).State = EntityState.Added;// объект будет добавлен как новый
            else
                context.Entry(product).State = EntityState.Modified;// старый объект будет изменён
            context.SaveChanges();
        }

        public void DeleteProduct(Guid idProduct, Guid idUser)
        {
            UserProducts userProduct = context.UserProducts.Where(x => x.IdProduct == idProduct && x.IdUser == idUser)
                                            .FirstOrDefault();

            context.UserProducts.Remove(userProduct);

            context.SaveChanges();
        }
    }
}
