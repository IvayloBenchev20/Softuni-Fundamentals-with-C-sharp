using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyborardPrice = double.Parse(Console.ReadLine());
            double monitorPrice = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            int trashedKeyboard = 0;

            for (int i = 2; i <= countOfLostGames; i+=2)
            {
                totalPrice += headsetPrice;
            }
            
            for (int j = 3; j <= countOfLostGames; j += 3)
            {
                totalPrice += mousePrice;
            }
           
            for (int k = 6; k <= countOfLostGames; k += 6)
            {
                totalPrice += keyborardPrice;
                trashedKeyboard++;

                if (trashedKeyboard % 2 ==0)
                {
                    totalPrice += monitorPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {totalPrice} lv.");
            

        }
    }
}
