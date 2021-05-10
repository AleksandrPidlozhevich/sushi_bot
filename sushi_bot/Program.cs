using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace sushi_bot
{
    class Program
    {

        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("Начало работы программы");
            Person.Introduce();
            Menu.BuildOrder();
            Menu.Order();
            Console.WriteLine(Menu.ShowAllOrder());
            Logger.Log.Info("Заказ укомплектован");
            MailLogic.EnterEmailAdress();
            MailLogic.SendMessage();
            Logger.Log.Info("Информация о заказе почту.");
            Console.WriteLine("Спасибо за заказ!");
        }
    }
}