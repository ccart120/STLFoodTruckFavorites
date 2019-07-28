using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace STLFoodTruckFavorites.Controllers
{
    public class FoodTruckController : Controller
    {
        //add this to get user id from db context to then associate things with it

        //public LocationController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        //{
        //    this.context = context;
        //    this.userManager = userManager;
        //}

        public IActionResult Index()
        {
            //what would admin index have?
            //list of food trucks
            
            return View();
        }

        //create a separate controller, object entirely for FoodTruckListItems
        //in this controller, only the admin uses/is associated with
        //Index method?
        //I want the user to view a list of locations associated with their id
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        
        

    }
}