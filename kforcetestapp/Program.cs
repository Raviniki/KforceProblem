using System;

namespace kforcetestapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter a ticket Amount");
            var tickitamount = Console.ReadLine();
            int TickitCost = 0;
            int EarnedPoint = 0;
            bool b = int.TryParse(tickitamount, out TickitCost);
            if(TickitCost > 50 && TickitCost < 100)
            {
                EarnedPoint = TickitCost - 50;
                Console.WriteLine("Earned Point Is {0}", EarnedPoint);
            }else if(TickitCost > 100)
            {
                EarnedPoint = (TickitCost - 100) * 2 + 50;
                Console.WriteLine("Earned Point Is {0}", EarnedPoint);

            }
            else
            {
                Console.WriteLine("Earned Point Is 0");
            }
        }
    }
}
