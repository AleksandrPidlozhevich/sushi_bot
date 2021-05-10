using System;
using System.Collections.Generic;
using System.Text;

namespace sushi_bot
{
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int CookingTime { get; set; }
        public int Count { get; set; }
        public Food(String name, int price, int cookingTime)
        {
            Name = name;
            Price = price;
            CookingTime = cookingTime;
        }
    }
}
