using ClothingAppAPI.DAL;
using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(ClothingContext clothingContext) : base(clothingContext)
        {
        }
    }
}
