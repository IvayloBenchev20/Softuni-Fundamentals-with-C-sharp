using System;

namespace Exercise_Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int fourthInteger = int.Parse(Console.ReadLine());

            int total = firstInteger + secondInteger;
            total /= thirdInteger;
            total *= fourthInteger;

            Console.WriteLine(total);
        }
    }
}
