﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_and_Basic_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:F2}");
        }
    }
}
