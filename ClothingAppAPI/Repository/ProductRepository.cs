using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothingAppAPI.DAL;

namespace ClothingAppAPI.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ClothingContext clothingContext) : base(clothingContext)
        {
        }

    }
}
