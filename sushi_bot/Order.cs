using System;
using System.Collections.Generic;
using System.Text;

namespace sushi_bot
{
    public class Order
    {
        public int NumberDish { get; set; }
        public int CountDish { get; set; }
        public int Sum(int CountDish, int Price)
        {
            int Sum = CountDish * Price;
            return Sum;
        }
    }
}