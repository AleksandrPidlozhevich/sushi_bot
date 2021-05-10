using System;
using System.Collections.Generic;
using System.Text;

namespace sushi_bot
{
    public static class InputHandler
    {
        public static int Sum;
        public static bool isInput = true;
        public static string input;
        public static void Input()
        {
            Console.WriteLine("Введите цифру и кол-во через пробел, если корзина готова нажмите 0");
            while (isInput)
            {
                input = Console.ReadLine();
                if (input.Equals("0"))
                {
                    return;
                }

                Order math = new Order();
                ConvertToInt conv = new ConvertToInt();

                math.NumberDish = conv.ConvertNumberDish(input);
                math.CountDish = conv.ConvertCountDish(input);

                if (math.NumberDish <= 10)
                {
                }
                else
                {
                    Console.WriteLine("Такого блюда не существует, введите заново");
                    input = Console.ReadLine();

                    math.NumberDish = conv.ConvertNumberDish(input);
                    math.CountDish = conv.ConvertCountDish(input);
                }

                for (int i = Menu.food.Count - 1; i >= 0; i--)
                {
                    if ((i + 1).Equals(math.NumberDish))
                    {
                        Menu.AddToFoodOrder(Menu.food[math.NumberDish - 1]);
                        Menu.food[i].Count = math.CountDish;
                        Sum += math.Sum(math.CountDish, Menu.food[math.NumberDish - 1].Price);
                    }
                }
            }
        }
    }
}