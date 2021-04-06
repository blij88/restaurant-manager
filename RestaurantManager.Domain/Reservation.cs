using RestaurantManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManager.models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int Table { get; set; }
        public string  Name { get; set; }
        public DateTime ReservationStart { get; set; }
        public DateTime ReservationEnd { get; set; }
        public bool LunchOrDinner { get; set; }
        public List<Order> Orders { get; set; }
    }
}
