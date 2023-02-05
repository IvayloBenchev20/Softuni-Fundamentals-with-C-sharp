using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Intro_and_Basic_synthax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string result = age <= 2 ? "baby" :
                age > 2 && age <= 13 ? "child" :
                age > 13 && age <= 19 ? "teenager" :
                age > 19 && age <= 65 ? "adult" : "elder";


            Console.WriteLine(result);

            //int age = int.Parse(Console.ReadLine());
            //string result = string.Empty;

            //if (age >=0 && age <=2)
            //{
            //    result = "baby";
            //}
            //else if (age >= 3 && age <= 13)
            //{
            //    result = "child";
            //}
            //else if (age >= 14 && age <= 19)
            //{
            //    result = "teenager";
            //}
            //else if (age >= 20 && age <= 65)
            //{
            //    result = "adult";
            //}
            //else
            //{
            //    result = "elder";
            //}

            //Console.WriteLine(result);
        }
    }
}
