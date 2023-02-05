using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Strong_Numbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyOfNumber = number;
            int sum = 0;

            while (number > 0)
            {
                int factorial = 1;
                int currentNumber = number % 10;
                number /= 10;
                for (int i = 2; i <= currentNumber; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }
            Console.WriteLine(sum == copyOfNumber ? "yes" : "no");
            


        }
    }
}
