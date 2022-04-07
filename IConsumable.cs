using System;
using System.Collections.Generic;

namespace FoodSpace
{
    public interface IConsumable
    {
        string GetInfo();

        string Name { get; set; }
        int Calories { get; set; }
        bool IsSpicy { get; set; }
        bool IsSweet { get; set; }
    }

    class Buffet
    {
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("chicken", 300, false, false),
                new Food("salad", 200, false, false),
                new Food("cake", 450, false, true),
                new Food("garlic bread", 400, false, false),
                new Food("steak", 400, false, false),
                new Food("curry", 400, true, false),
                new Food("pecan pie", 500, false, true),
                new Drink("McDonald's Sprite", 300, true),
                new Drink("Water", 0, false),
                new Drink("Orange Juice", 120, false)
            };
        }

        public IConsumable Serve()
        {
            Console.WriteLine("Serving...");
            Random random = new Random();
            int randomNumber = random.Next(0, Menu.Count);
            IConsumable item = Menu[randomNumber];
            Console.WriteLine(item.GetInfo());
            return item;
        }

        public List<IConsumable> Menu;
    }
}