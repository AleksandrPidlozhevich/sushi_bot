using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text;

namespace sushi_bot
{
    public class FoodRepository
    {
        //Json
        public List<Food> sushi = new List<Food>();
        public List<Food> addSushi()
        {
            sushi.Add(new Food("Сяке маки", 280, 10));
            sushi.Add(new Food("Филадельфия Кунсей маки", 215, 15));
            sushi.Add(new Food("Нигири Магуро", 250, 13));
            sushi.Add(new Food("Тай маки", 220, 10));
            sushi.Add(new Food("Эби Калифорния маки", 180, 14));
            sushi.Add(new Food("Сакано маки", 230, 15));
            sushi.Add(new Food("Кайсо", 190, 17));
            sushi.Add(new Food("Омура", 270, 20));
            return sushi;
        }
        public void WriteToJason()
        {
            addSushi();
            File.WriteAllText("FoodRepository.json", JsonConvert.SerializeObject(sushi));
        }
        public void ReadFromJason()
        {
            List<Food> food = new List<Food>();
            food = JsonConvert.DeserializeObject<List<Food>>(File.ReadAllText("FoodRepository.json"));
            foreach (var item in food)
            {
                Console.WriteLine(item.Price.ToString());
            }
        }
    }
}