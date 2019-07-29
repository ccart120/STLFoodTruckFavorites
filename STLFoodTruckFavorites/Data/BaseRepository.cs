using STLFoodTruckFavorites.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace STLFoodTruckFavorites.Data
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IModel
    {
        protected ApplicationDbContext context;
        protected DbSet<TEntity> models;

        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.models = context.Set<TEntity>();

        }
            public void Delete(int id)
        {
            var model = this.GetByID(id);
            context.Remove(model);
            context.SaveChanges();
        }

        public TEntity GetByID(int id)
        {
            return models.SingleOrDefault(m => m.ID == id);
        }

        public List<TEntity> GetModels()
        {
            return models.ToList();
        }

        public int Save(TEntity model)
        {
            context.Add(model);
            context.SaveChanges();
            return model.ID; ;
        }

        public void Update(TEntity model)
        {
            context.Update(model);
            context.SaveChanges(); 
            //return model.ID;
        }
    }
}
