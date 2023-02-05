using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
          //var multiplier = 1;

            for (int i = 1; i <= 10; i++)
            {
                int sum = number * i;
                Console.WriteLine($"{number} X {i} = {sum}");

            }
          //  while (multiplier <=10)
          //  {
          //      Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
          //      multiplier++;
          //  }
        }
    }
}
