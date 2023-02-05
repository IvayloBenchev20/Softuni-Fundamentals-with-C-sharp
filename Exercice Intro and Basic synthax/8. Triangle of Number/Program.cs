using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Triangle_of_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int  row = 1; row <= number;  row++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write($"{row} ");

                }
                Console.WriteLine();   
            }
        }
    }
}
