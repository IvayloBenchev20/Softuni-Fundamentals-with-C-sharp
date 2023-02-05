using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 10 == 0)
            {
                int divisibleNumber = 10;
                Console.WriteLine($"The number is divisible by {divisibleNumber} ");
            }
            else if (number % 7 == 0)
            {
                int divisibleNumber = 7;
                Console.WriteLine($"The number is divisible by {divisibleNumber}");
            }
            else if (number % 6 == 0)
            {
                int divisibleNumber = 6;
                Console.WriteLine($"The number is divisible by {divisibleNumber}");
            }
            else if (number % 3 == 0)
            {
                int divisibleNumber = 3;
                Console.WriteLine($"The number is divisible by {divisibleNumber}");
            }
            else if (number % 2 == 0)
            {
                int divisibleNumber = 2;
                Console.WriteLine($"The number is divisible by {divisibleNumber}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
