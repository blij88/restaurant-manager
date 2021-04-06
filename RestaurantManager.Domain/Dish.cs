using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManager.models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category DishType { get; set; }
        public int Stock { get; set; }
        public bool BTW { get; set; }
        public double price { get; set; }
    }
}