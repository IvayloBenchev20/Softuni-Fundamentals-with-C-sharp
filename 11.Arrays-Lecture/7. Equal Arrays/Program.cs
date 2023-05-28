using System;
using System.Linq;

namespace _7.Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstLineInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLineInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int totalSum = 0;
            int counter = 0; // can be simplified

            for (int i = 0; i < firstLineInput.Length; i++)
            {
                if (firstLineInput[i] != secondLineInput[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    counter++;
                    totalSum += firstLineInput[i];
                }
                if (counter == firstLineInput.Length) // i == firstLineOfInput[i]-1
                {
                    Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
                }
            }
        }
    }
}
