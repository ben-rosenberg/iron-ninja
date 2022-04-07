using System;
using FoodSpace;
using People;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            SpiceHound spiceHound = new SpiceHound();
            SweetTooth sweetTooth = new SweetTooth();

            while (!spiceHound.IsFull)
            {
                spiceHound.Consume(buffet.Serve());
            }

            while (!sweetTooth.IsFull)
            {
                sweetTooth.Consume(buffet.Serve());
            }

            int sweetToothNumConsumed = sweetTooth.ConsumptionHistory.Count;
            int spiceHoundNumConsumed = spiceHound.ConsumptionHistory.Count;

            if (sweetToothNumConsumed == spiceHoundNumConsumed)
            {
                Console.WriteLine($"Both consumed the same number of items ({sweetToothNumConsumed} vs. {spiceHoundNumConsumed})");
            }
            else if (sweetToothNumConsumed > spiceHoundNumConsumed)
            {
                Console.WriteLine($"Sweet Tooth consumed more items ({sweetToothNumConsumed} vs. {spiceHoundNumConsumed})");
            }
            else
            {
                Console.WriteLine($"Spice Hound consumed more items ({spiceHoundNumConsumed} vs. {sweetToothNumConsumed})");
            }
        }
    }
}
