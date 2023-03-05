using System;

namespace _4.Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short centuries = short.Parse(Console.ReadLine());
            int yearsOfOneCentury = centuries * 100;
            int daysOfOneCentury =(int)(yearsOfOneCentury * 365.2422);
            double hoursOfOneCentury = daysOfOneCentury * 24;
            long minutes = (long)(hoursOfOneCentury * 60.0);
            Console.WriteLine($"{centuries} centuries = {yearsOfOneCentury} years = {daysOfOneCentury} days = {hoursOfOneCentury} hours = {minutes} minutes");

        }
    }
}
