using System;

namespace _09.Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MINIMUM_YIELD_TO_GATHER = 100;
            const int DAILY_DECREES_OF_MINE_YEILD = 10;

            int startingYield = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int workingDays = 0;
            int totalYieldLeft = 0;

            while (startingYield >= MINIMUM_YIELD_TO_GATHER)
            {
                totalConsumed += startingYield - CONSUMED_BY_WORKERS;
                workingDays++;
                totalYieldLeft += totalConsumed;
                startingYield -= DAILY_DECREES_OF_MINE_YEILD;
                if (startingYield < MINIMUM_YIELD_TO_GATHER)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }

            }
            Console.WriteLine(workingDays);
            Console.WriteLine(totalConsumed);
        }
    }
}
