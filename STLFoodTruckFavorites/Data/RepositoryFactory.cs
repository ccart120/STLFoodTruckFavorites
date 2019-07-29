using STLFoodTruckFavorites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STLFoodTruckFavorites.Data
{
    public class RepositoryFactory
    {
        private ApplicationDbContext context;

        public RepositoryFactory(ApplicationDbContext context)
        {
            this.context = context;
        }

        
    }
}
