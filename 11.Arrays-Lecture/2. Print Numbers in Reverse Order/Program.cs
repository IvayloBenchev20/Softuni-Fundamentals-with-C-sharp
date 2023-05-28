using System;

namespace _2.Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] arrayOfInput = new int[input];

            for (int i = 0; i < arrayOfInput.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arrayOfInput[i] = number;
            }

            for (int i = arrayOfInput.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayOfInput[i] + " ");
            }
        }
    }
}
