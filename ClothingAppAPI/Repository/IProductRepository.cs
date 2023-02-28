using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothingAppAPI.Models;

namespace ClothingAppAPI.Repository
{
    public interface IProductRepository
    {
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        Product GetProductById(int productId);
        IEnumerable<Product> GetProductList();

    }
}
