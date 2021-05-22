using Pizza.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain.Repositories.Abstract
{
    public interface IUserProductsRepository
    {
        List<Product> GetByUserId(Guid id);
        void SaveProduct(UserProducts userProduct);
        void DeleteProduct(Guid idProduct, Guid idUser);
    }
}
