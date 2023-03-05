using System;
using System.Configuration;

namespace _08.Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggestKeg = Double.MinValue;
            string biggestKegName = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfCurrentKeg = Math.PI * Math.Pow(radius, 2) * height;
                if (volumeOfCurrentKeg > biggestKeg)
                {
                    biggestKeg = volumeOfCurrentKeg;
                    biggestKegName = model;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
