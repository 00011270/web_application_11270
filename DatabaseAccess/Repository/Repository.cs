using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothingAppAPI.DAL;
using ClothingAppAPI.DPattern;
using ClothingAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothingAppAPI.Repository
{
    // This is the Generic implementation of the IRepository interface.
    // Here is provided the generic implementation of CRUD operation.
    // This class can be now extended by a specific entity Repository class and only sent a dbContext
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ClothingContext dbContext;

        public Repository(ClothingContext clothing)
        {
            dbContext = clothing;
        }

        public async Task<T> GetObjectById(int obj)
        {
            return await dbContext.Set<T>().FindAsync(obj);
        }

        public async Task<IEnumerable<T>> GetObjectList()
        {
             return await dbContext.Set<T>().ToListAsync();
        }

        public async Task InsertObject(T obj)
        {
            await dbContext.Set<T>().AddAsync(obj);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateObject(T obj)
        {
            dbContext.Set<T>().Update(obj);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteObject(int objId)
        {
            var obj = dbContext.Set<T>().Find(objId);
            dbContext.Set<T>().Remove(obj);
            await dbContext.SaveChangesAsync();
        }

        
    }
}
