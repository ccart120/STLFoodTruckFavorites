using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STLFoodTruckFavorites.Data;
using STLFoodTruckFavorites.ViewModels;

namespace STLFoodTruckFavorites.Controllers
{
    public class FoodTruckController : Controller
    {
        private RepositoryFactory repositoryFactory;

        public FoodTruckController(RepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }
        //THE FOLLOWING WILL BE ADDED TO THE USER CONTROLLERS
        //add this to get user id from db context to then associate things with it

        //public LocationController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        //{
        //    this.context = context;
        //    this.userManager = userManager;
        //}

        //this may by the code for cookies
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        public IActionResult Index()
        {
            //what would admin index have?
            //list of food trucks

            
            return View();
        }

        //create a separate controller, object entirely for FoodTruckListItems
        //in the FoodTruck controller, only the admin uses/is associated with
        //Index method?
        //I want the user to view a list of locations associated with their id
        [HttpGet]
        public IActionResult Create()
        {
            FoodTruckCreateViewModel model = FoodTruckCreateViewModel.GetFoodTruckCreateViewModel();
            return View();
        }
        [HttpPost]
        public IActionResult Create(FoodTruckCreateViewModel model)
        {
            model.Persist(repositoryFactory);
            return View();
        }





    }
}