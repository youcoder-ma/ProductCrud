using ProductMg.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductMg.Data
{
    public interface IProductRepository
    {
        Task Initialize();
        Task<List<Product>> GetProducts();
        Task AddOrUpdate(Product product);
    }
}
