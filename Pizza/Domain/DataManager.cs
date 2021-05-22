using Pizza.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Domain.Entities
{
    public class DataManager
    {
        public IProductsRepository Products { get; set; }
        public IUserProductsRepository UserProducts { get; set; }

        public DataManager(IProductsRepository productsRepository, IUserProductsRepository userProductsRepository)
        {
            Products = productsRepository;
            UserProducts = userProductsRepository;
        }
    }
}
