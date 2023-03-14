using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothingAppAPI.DAL;

namespace ClothingAppAPI.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private static ProductRepository productRepository;
        public ProductRepository(ClothingContext clothingContext) : base(clothingContext)
        {
        }

        public static ProductRepository GetInstance(ClothingContext clothing)
        {
            if(productRepository == null)
            {
                productRepository = new ProductRepository(clothing);
            }
            return productRepository;
        }
    }
}
