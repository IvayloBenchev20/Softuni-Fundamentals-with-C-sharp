using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFromTheConsole = Console.ReadLine();
            string[] inputSplit = inputFromTheConsole.Split(' ');

            for (int i = inputSplit.Length - 1; i >= 0; i--)
            {
                Console.Write($"{inputSplit[i]} ");
            }
        }
    }
}
