using Microsoft.EntityFrameworkCore;
using RestaurantManager.Domain;
using RestaurantManager.models;

namespace RestaurantManager.Data
{
    public class RestaurantContext:DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) :base(options)
        {

        }
        public DbSet<Dish> dishes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
