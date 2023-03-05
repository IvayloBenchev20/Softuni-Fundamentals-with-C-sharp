using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowBalls = int.Parse(Console.ReadLine());
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;
            BigInteger bestSnowball = int.MinValue;
            string bestSnowballFormula = String.Empty;


            for (int i = 0; i < numberOfSnowBalls; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(currentSnowballValue, snowballQuality);

                if (snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    bestSnowballFormula = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }

            }

            Console.WriteLine(bestSnowballFormula);
        }
    }
}
