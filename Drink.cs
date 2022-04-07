using System;

namespace FoodSpace
{
    class Drink : IConsumable
    {
        public Drink(string name, int calories, bool isSpicy)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = true;

            if (name == "McDonald's Sprite")
            {
                IsSpicy = true;
            }
        }

        public string GetInfo()
        {
            string spicy = IsSpicy ? "Yes" : "No";
            return $"{Name} (Drink); Calories: {Calories}; Spicy? {spicy}; Sweet? Yes.";
        }

        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }
    }
}