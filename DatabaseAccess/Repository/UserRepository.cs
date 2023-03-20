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
        private static UserRepository userRepository;
        public UserRepository(ClothingContext clothingContext) : base(clothingContext)
        {
        }

        public static UserRepository GetInstance(ClothingContext clothingContext)
        {
            if(userRepository == null)
            {
                userRepository = new UserRepository(clothingContext);
            }
            return userRepository;
        }
    }
}
