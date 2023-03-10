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
    public class Repository<T> : IRepository<T> where T : class, Prototype
    {
        private readonly ClothingContext dbContext;

        public Repository(ClothingContext clothingContext)
        {
            dbContext = clothingContext;
        }


        public void DeleteObject(int objId)
        {
            var obj = dbContext.Set<T>().Find(objId);
            dbContext.Set<T>().Remove(obj);
            dbContext.SaveChanges();
        }

        public T GetObjectById(int obj)
        {
            return dbContext.Set<T>().Find(obj).Clone() as T;
        }

        public IEnumerable<T> GetObjectList()
        {
            var originalObjects = dbContext.Set<T>().ToList();
            return originalObjects.Select(dataObj => dataObj.Clone() as T);
        }

        public void InsertObject(T obj)
        {
            dbContext.Set<T>().Add(obj);
            dbContext.SaveChanges();
        }

        public void UpdateObject(T obj)
        {
            dbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
