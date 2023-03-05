using System;

namespace _10.Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaust = int.Parse(Console.ReadLine());
            int startingPower = power;
            int reachedTargetCounter = 0;

            while (power >= distance)
            {
                power -= distance;
                reachedTargetCounter++;

                if (startingPower * 0.5 == power && exhaust > 0)
                {
                    power /= exhaust;

                }

            }
            Console.WriteLine(power);
            Console.WriteLine(reachedTargetCounter);
        }
    }
}
