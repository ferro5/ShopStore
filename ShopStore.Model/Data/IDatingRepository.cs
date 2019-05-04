using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShopStore.Model.Models;

namespace ShopStore.Model.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<Brand> GetBrand(int id);
        Task<Category> GetCategory(int id);

    }
}
