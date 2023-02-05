using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string langugage = String.Empty;

            switch (country)
            {
                case "USA":
                case "England":
                    langugage = "English";
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    langugage = "Spanish";
                    break;

                default:
                    langugage = "unknown";
                    break;
            }

            Console.WriteLine(langugage); 
        }
    }
}
