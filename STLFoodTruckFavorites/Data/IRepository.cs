using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STLFoodTruckFavorites.Data
{
    public interface IRepository<T>
    {
        T GetByID(int id);
        List<T> GetModels();
        int Save(T model);
        void Update(T model);
        void Delete(int id);
    }
}
