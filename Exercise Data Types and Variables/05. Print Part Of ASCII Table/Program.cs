using System;

namespace _05.Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.OutputEncoding = System.Text.Encoding.UTF8;

            int firstLine = int.Parse(Console.ReadLine());
            int secondLine = int.Parse(Console.ReadLine());
            
            for (int i = firstLine; i <= secondLine; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
