using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Percentage
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, obtainedmarks,percentage;
            int total = 300;
            Console.WriteLine("marks obtained in physics");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("marks obtained in Chemistry");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("marks obtained in Maths");
            num3 = Convert.ToInt32(Console.ReadLine());

            obtainedmarks = num1 + num2 + num3;
            percentage = obtainedmarks * 100 / total;
            Console.WriteLine($"sum  of {num1}, {num2} and {num3} = {obtainedmarks},");
            Console.WriteLine($"Percentage of  {num1}, {num2} and {num3} ={percentage}" );
        }
    }
}
