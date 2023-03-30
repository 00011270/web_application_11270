using ClothingAppAPI.DAL;
using ClothingAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingAppAPI.Repository
{
    public class ReviewRepository : Repository<Review>
    {
        private static ReviewRepository reviewRepo;
        private readonly ClothingContext context;

        public ReviewRepository(ClothingContext clothingContext) : base(clothingContext)
        {
            context = clothingContext;
        }
        public async Task<IEnumerable<Review>> GetReviewsForProduct(int productId)
        {
            return await context.Reviews
                .Where(res => res.ProductId == productId)
                .ToListAsync();
        }

    }
}
