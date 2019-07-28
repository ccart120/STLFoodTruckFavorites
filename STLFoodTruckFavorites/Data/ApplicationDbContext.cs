using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using STLFoodTruckFavorites.Models;

namespace STLFoodTruckFavorites.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<FoodTruck> FoodTrucks { get; set; }
        public DbSet<Location> Locations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
