using RestaurantManager.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManager.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public Reservation Reservation { get; set; }
        public int ReservationId { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
