using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingAppAPI.Repository
{

    // Generic Repository Interface where basic CRUD methods are implemented.
    // By making this interface Generic, means that it is not specific object related
    // and this inteface is written once. However, if Generic type was not used, there would be
    // this kind of repo interfaces for every entity
    public interface IRepository<T> where T:class
    {

        //Implementing CRUD methods that the most the of entities will use.
        Task InsertObject(T obj);
        Task DeleteObject(int objId);
        Task UpdateObject(T obj);
        Task<T> GetObjectById(int obj);
        Task<IEnumerable<T>> GetObjectList();
    }
}
