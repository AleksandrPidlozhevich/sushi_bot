using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace sushi_bot
{
    public static class Menu
    {
        public static List<Food> food;
        public static List<Food> foodOrder = new List<Food> { };
        public static void AllMenu()
        {
            food = JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText("FoodRepository.json"));
        }
        public static void ShowAllMenu()
        {
            for (int i = 0; i < food.Count; i++)
            {
                int a = i + 1;
                Console.WriteLine(a + " " + food[i].Name + " " + food[i].Price.ToString());
            }
        }
        public static void BuildOrder()
        {
            Console.WriteLine(Person.Name + " вы знаете что хотите заказать или вам нужно меню?");
            Console.WriteLine("1. нужно меню");
            Console.WriteLine("2. не нужно меню");
            Console.WriteLine(" ");
            Console.WriteLine("Введите цифру ответа");
        }
        public static void Order()
        {
            string answer = Console.ReadLine();
            Console.Clear();
            switch (answer)
            {
                case "1":
                    AllMenu();
                    ShowAllMenu();
                    InputHandler.Input();
                    break;
                case "2":
                    AllMenu();
                    InputHandler.Input();
                    break;
                default:
                    Console.WriteLine("Что-то не так, попробуйте ещё раз.");
                    BuildOrder();
                    Order();
                    break;
            }
        }
        public static void AddToFoodOrder(Food food)
        {
            foodOrder.Add(food);
        }
        public static string ShowAllOrder()
        {
            string message = " Вы заказали следующее: \n" + GetOrder() + " На сумму: " + InputHandler.Sum;
            return message;
        }
        public static string GetOrder()
        {
            Order Count = new Order();
            int maxCoockingTime = 0;
            string order = "";
            for (int i = 0; i < foodOrder.Count; i++)
            {
                if (foodOrder[i].CookingTime > maxCoockingTime)
                {
                    maxCoockingTime = foodOrder[i].CookingTime;
                }
                order += (foodOrder[i].Name + " " + foodOrder[i].Count + "шт" + "\n");
            }
            order += "Ваш заказ будет готов через " + maxCoockingTime.ToString() + " минут.";
            return order;
        }
    }
}
