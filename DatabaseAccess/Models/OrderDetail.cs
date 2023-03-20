using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public Double TotalCost { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
