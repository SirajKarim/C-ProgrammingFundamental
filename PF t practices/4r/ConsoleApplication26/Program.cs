using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        { // area of trinagle//
            Console.WriteLine("enter base");
            double baseValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter hieght");
            double hieghtValue = Convert.ToDouble(Console.ReadLine());
            double a = baseValue * hieghtValue;
            double b = 0.5;
            double c = a * b;
           Console.WriteLine("the area of triangle = "+c);
        }
    }
}
