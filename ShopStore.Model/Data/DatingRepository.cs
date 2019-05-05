using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopStore.Model.Models;

namespace ShopStore.Model.Data
{
    public class DatingRepository : IDatingRepository
    {
        private ApplicationDbContext _context;
        public DatingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Brand> GetBrand(int id)
        {
            var brand = await _context.Brands.FirstOrDefaultAsync(b => b.BrandId == id);
            return brand;
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
            return category;
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.Where(p => p.ProductId == id).Include(p=>p.Brand).Include(c=>c.Category).FirstOrDefaultAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await _context.Products.Include(p => p.Category).Include(b => b.Brand).ToListAsync();
            return products;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
