using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;

            switch (typeOfTheGroup)
            {
                case "Students":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 10.46;
                    }
                    break;
                case "Business":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 15;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 20;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 22.50;
                    }
                    break;
            }
            double totalPrice = countOfPeople * price;

            if (typeOfTheGroup == "Students" && countOfPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (typeOfTheGroup == "Business" && countOfPeople >= 100)
            {
                totalPrice -= totalPrice / countOfPeople * 10;
            }
            else if (typeOfTheGroup == "Regular" && countOfPeople >= 10 && countOfPeople <=20)
            {
                totalPrice -= totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
