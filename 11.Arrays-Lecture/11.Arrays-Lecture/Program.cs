using System;

namespace _11.Arrays_Lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());

            string[] arrayDayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayOfWeek >= 1 && dayOfWeek <= arrayDayOfWeek.Length)
            {
                dayOfWeek--;
                Console.WriteLine(arrayDayOfWeek[dayOfWeek]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
