using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothingAppAPI.DAL;

namespace ClothingAppAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ClothingContext _dbContext;

        public ProductRepository(ClothingContext clothingContext)
        {
            _dbContext = clothingContext;
        }

        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            return _dbContext.Products.Find(productId);
        }

        public IEnumerable<Product> GetProductList()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
