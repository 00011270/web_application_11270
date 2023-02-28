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
        void InsertObject(T obj);
        void DeleteObject(int objId);
        void UpdateObject(T obj);
        T GetObjectById(int obj);
        IEnumerable<T> GetObjectList();
    }
}
