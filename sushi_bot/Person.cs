using System;
using System.Collections.Generic;
using System.Text;

namespace sushi_bot
{
    public static class Person
    {
        public static string Name { get; set; }
        public static string EmailAdress { get; set; }
        public static string Password { get; set; }
        public static void Introduce()
        {
            Console.WriteLine("Здравствуйте, как ваше имя ?");
            Name = Console.ReadLine();
            Console.Clear();
        }
    }
}