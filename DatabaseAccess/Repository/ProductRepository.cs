using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothingAppAPI.DAL;
using Microsoft.EntityFrameworkCore;

namespace ClothingAppAPI.Repository
{
    public class ProductRepository : Repository<Product>
    {
        private static ProductRepository productRepository;
        private readonly ClothingContext context;
        public ProductRepository(ClothingContext clothingContext) : base(clothingContext)
        {
            this.context = clothingContext;
        }

        public static ProductRepository GetInstance(ClothingContext clothing)
        {
            if(productRepository == null)
            {
                productRepository = new ProductRepository(clothing);
            }
            return productRepository;
        }

        public async Task<IEnumerable<Product>> GetProductByCategoryId(int categoryId)
        {
            return await context.Products.Where(product => product.CategoryId == categoryId).ToListAsync();
        }
    }
}
