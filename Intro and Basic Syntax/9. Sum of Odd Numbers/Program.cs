using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                int currentOddNumber = 1 + (i * 2);

                // i == 0; currentOddNumber = 1 + (0*2) = 1
                // i == 1; currentOddNumber = 1 + (1*2) = 3
                // i == 2; currentOddNumber = 1 + (2*2) = 5

                Console.WriteLine(currentOddNumber);
                sum += currentOddNumber;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
