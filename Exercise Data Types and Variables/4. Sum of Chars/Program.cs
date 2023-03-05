using System;

namespace _4.Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLine = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < numberOfLine; i++)
            {
                char inputOfChars = char.Parse(Console.ReadLine());
                int currentChar = (int)inputOfChars;
                totalSum += currentChar;
            }

            Console.WriteLine($"The sum equals: {totalSum}");

        }
    }
}
