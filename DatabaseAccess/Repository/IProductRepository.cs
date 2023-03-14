using ClothingAppAPI.Models;
using ClothingAppAPI.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingAppAPI.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
