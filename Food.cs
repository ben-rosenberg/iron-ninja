using System;
using System.Collections.Generic;

namespace FoodSpace
{
    class Food : IConsumable
    {
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }

        public string GetInfo()
        {
            string spicy = IsSpicy ? "Yes" : "No";
            string sweet = IsSweet ? "Yes" : "No";
            return $"{Name} (Food); Calories: {Calories}; Spicy? {spicy}; Sweet? {sweet}";
        }

        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }
    }
}