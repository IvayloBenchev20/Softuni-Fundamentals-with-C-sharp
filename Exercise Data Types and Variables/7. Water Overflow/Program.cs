using System;

namespace _7.Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            const int TANKCAPACUTY = 255;
            int totalQuantity = TANKCAPACUTY;

            for (int i = 0; i < lines; i++)
            {
                int currentQuantity = int.Parse(Console.ReadLine());
                
                if (totalQuantity - currentQuantity >= 0)
                {
                    totalQuantity -= currentQuantity;  

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            int totalFieldQuantity = TANKCAPACUTY - totalQuantity;
            Console.WriteLine(totalFieldQuantity);
            

        }
    }
}
