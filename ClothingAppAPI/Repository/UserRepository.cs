using ClothingAppAPI.DAL;
using ClothingAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ClothingContext _dbContext;
        
        public UserRepository(ClothingContext clothingContext)
        {
            _dbContext = clothingContext;
        }

        public void DeleteUser(int userId)
        {
            //Finds the user by id and stores it in varible
            var findUser = _dbContext.Users.Find(userId);

            //Deletes the user from database table by sending founded user var
            _dbContext.Users.Remove(findUser);
            _dbContext.SaveChanges();
        }

        public User GetUserById(int userId)
        {
            return _dbContext.Users.Find(userId);
        }

        public IEnumerable<User> GetUserList()
        {
            return _dbContext.Users.ToList();
        }

        public void InsertUser(User user)
        {
            //Inserts a new user to a database
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _dbContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
