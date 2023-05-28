using System;
using System.Linq;


namespace _05.Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFromTheConsole = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int totalSum = 0;

            for (int i = 0; i < arrayFromTheConsole.Length; i++)
            {
                while (arrayFromTheConsole[i] % 2 == 0)
                {
                    totalSum += arrayFromTheConsole[i];
                    break;
                }
            }
            Console.WriteLine(totalSum);

            // USING IF STATEMENT

            //int[] arrayFormTheConsole = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //int totalSum = 0;

            //for (int i = 0; i < arrayFormTheConsole.Length; i++)
            //{
            //    if (arrayFormTheConsole[i] % 2 == 0)
            //    {
            //        totalSum += arrayFormTheConsole[i];
            //    }
            //}
            //Console.WriteLine(totalSum);
        }
    }
}
