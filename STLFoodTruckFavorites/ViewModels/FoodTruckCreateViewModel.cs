using STLFoodTruckFavorites.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STLFoodTruckFavorites.ViewModels
{
    public class FoodTruckCreateViewModel
    {
        public static FoodTruckCreateViewModel GetFoodTruckCreateViewModel()
        {
            FoodTruckCreateViewModel model = new FoodTruckCreateViewModel();
            return model;
        }

        public void Persist(RepositoryFactory repositoryFactory)
        {
            Models.FoodTruck foodTruck = new Models.FoodTruck()
            {
                Name = this.Name,
                Description = this.Description,
            };
            repositoryFactory.GetFoodTruckRepository().Save(foodTruck);
        }




        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
