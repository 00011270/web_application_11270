using ClothingAppAPI.DAL;
using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Repository
{
    public class ProductCategoryRepository : Repository<ProductCategory>
    {
        private static ProductCategoryRepository productCategoryRepository;
        public ProductCategoryRepository(ClothingContext clothingContext) : base(clothingContext)
        {
        }

        /*public static ProductCategoryRepository GetInstance(ClothingContext clothing)
        {
            if (productCategoryRepository == null)
            {
                productCategoryRepository = new ProductCategoryRepository(clothing);
            }
            return productCategoryRepository;
        }*/
    }
}
