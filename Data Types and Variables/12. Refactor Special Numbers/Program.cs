using System;

namespace _12.Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int total = 0;
                int currentDigit = i;
                while (i > 0)
                {
                    total += i % 10;
                    i /= 10;
                }
                 bool isSpecialNumber = (total == 5) || (total == 7) || (total == 11);

                Console.WriteLine("{0} -> {1}", currentDigit, isSpecialNumber);

                i = currentDigit;
            }
        }
    }
}
