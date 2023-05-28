using System;
using System.Globalization;
using System.Linq;

namespace _8.Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (arrayOfNumbers.Length > 1)
            {
                int[] condesned = new int[arrayOfNumbers.Length - 1];
                for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
                {
                    condesned[i] = arrayOfNumbers[i] + arrayOfNumbers[i + 1];

                    if (i == arrayOfNumbers.Length - 2)
                    {
                        arrayOfNumbers = condesned;
                        condesned = new int[arrayOfNumbers.Length - 1];
                    }
                }

            }
            Console.WriteLine(arrayOfNumbers[0]);
        }
    }
}
