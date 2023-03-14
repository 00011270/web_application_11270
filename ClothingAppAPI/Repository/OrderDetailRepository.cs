using ClothingAppAPI.DAL;
using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>
    {
        private static OrderDetailRepository orderDetailRepository;
        public OrderDetailRepository(ClothingContext clothingContext) : base(clothingContext)
        {
        }

        public static OrderDetailRepository GetInstance(ClothingContext clothing)
        {
            if (orderDetailRepository == null)
            {
                orderDetailRepository = new OrderDetailRepository(clothing);
            }
            return orderDetailRepository;
        }
    }
}
