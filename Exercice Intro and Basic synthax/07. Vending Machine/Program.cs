using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double insertedCoins = 0;

            while (command != "Start")
            {
                double InputMoney = double.Parse(command);

                if (InputMoney == 0.1 || InputMoney == 0.2 || InputMoney == 0.5 || InputMoney == 1 || InputMoney == 2 )
                {
                    insertedCoins += InputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {InputMoney}");
                }
                command = Console.ReadLine();

            }
            command = Console.ReadLine();
            double priceOfProduct = 0;

            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        priceOfProduct = 2.0;
                        break;
                    case "Water":
                        priceOfProduct = 0.7;
                        break;
                    case "Crisps":
                        priceOfProduct = 1.5;
                        break;
                    case "Soda":
                        priceOfProduct = 0.8;
                        break;
                    case "Coke":
                        priceOfProduct = 1.0;
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        command = Console.ReadLine();
                        continue;
                }

                if (insertedCoins >= priceOfProduct)
                {
                    insertedCoins -= priceOfProduct;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
             Console.WriteLine($"Change: {insertedCoins:F2}");
        }
    }
}
