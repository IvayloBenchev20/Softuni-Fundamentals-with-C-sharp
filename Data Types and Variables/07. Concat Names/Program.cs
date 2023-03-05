using System;

namespace _07.Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            string result = firstName + delimeter + lastName;
            Console.WriteLine(result);
        }
    }
}
