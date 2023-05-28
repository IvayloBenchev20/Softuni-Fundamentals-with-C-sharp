using System;
using System.Linq;

namespace _6.Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputFromTheConsole = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < inputFromTheConsole.Length; i++)
            {
                if (inputFromTheConsole[i] % 2 == 0)
                {
                    evenSum += inputFromTheConsole[i];
                }
                else
                {
                    oddSum += inputFromTheConsole[i];
                }
            }
            Console.WriteLine($"{evenSum - oddSum}");
        }
    }
}
