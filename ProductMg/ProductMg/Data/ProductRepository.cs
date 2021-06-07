using ProductMg.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProductMg.Data
{
    public class ProductRepository : IProductRepository
    {
        public SQLiteAsyncConnection _connection;

        public async Task AddOrUpdate(Product product)
        {
            if(product.Id != 0)
            {
                 await _connection.UpdateAsync(product);
            }
            else
            {
                 await _connection.InsertAsync(product);
            }
        }

        public Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public async Task Initialize()
        {
            if (_connection != null) 
                return;
            _connection = new SQLiteAsyncConnection(Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "product.db3"));

            await _connection.CreateTableAsync<Product>();
        }
    }
}
