﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Division
    {
        static void Main(string[] args)
        {
            int num1, num2, div;
            Console.WriteLine("Enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());

            div = num1 / num2;
            Console.WriteLine($"Division of{num1}and {num2} is {div}");
        }
    }
}
