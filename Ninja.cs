using System;
using System.Collections.Generic;
using FoodSpace;

namespace People
{
    abstract class Ninja
    {
        public Ninja()
        {
            _CalorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        public abstract bool IsFull { get; }
        public abstract void Consume(IConsumable item);

        protected int _CalorieIntake;
        public List<IConsumable> ConsumptionHistory;
    }

    class SweetTooth : Ninja
    {
        public SweetTooth() : base() {}
        public override bool IsFull
        {
            get { return (_CalorieIntake > 1500); }
        }

        public override void Consume(IConsumable item)
        {
            if (IsFull)
            {
                Console.WriteLine("Already full! Can't eat any more");
                return;
            }

            Console.WriteLine("Sweet Tooth: Consuming...");

            _CalorieIntake += item.Calories;
            _CalorieIntake += item.IsSweet ? 10 : 0;
            ConsumptionHistory.Add(item);

            Console.WriteLine(item.GetInfo());
        }
    }

    class SpiceHound : Ninja
    {
        public SpiceHound() : base() {}

        public override bool IsFull
        {
            get { return (_CalorieIntake > 1200); }
        }

        public override void Consume(IConsumable item)
        {
            if (IsFull)
            {
                Console.WriteLine("Already full! Can't eat any more");
                return;
            }

            Console.WriteLine("Spice Hound: Consuming...");

            _CalorieIntake += item.Calories;
            _CalorieIntake -= item.IsSpicy ? 5 : 0;
            ConsumptionHistory.Add(item);

            Console.WriteLine(item.GetInfo());
        }
    }
}