using System;

namespace _9.Padawan_Equipmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOflightSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine()); 
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalNumberOfSabers = Math.Ceiling(countOfStudents * 1.10);
            double numbersOfFreeBelts = Math.Floor(countOfStudents / 6.00);
            
            double finalPriceOfSabers = totalNumberOfSabers * priceOflightSabers;
            double finalPriceOfBelts = (countOfStudents - numbersOfFreeBelts) * priceOfBelts;
            double finalPriceOfRobes = priceOfRobes * countOfStudents;

            double totalFinalPrice = finalPriceOfSabers + finalPriceOfBelts + finalPriceOfRobes;

            if (amountOfMoney >= totalFinalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalFinalPrice - amountOfMoney):F2}lv more.");
            }
        }
    }
}
