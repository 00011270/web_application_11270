using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Repository
{
    public interface IUserRepository
    {
        void InsertUser(User user);
        
        void UpdateUser(User user);
        void DeleteUser(int userId);
        User GetUserById(int userId);
        IEnumerable<User> GetUserList();
    }
}
