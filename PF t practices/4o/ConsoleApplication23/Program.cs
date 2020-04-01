using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            // find area of circle //
            Console.WriteLine("enter the radius of circle");
            double radiusValue = Convert.ToDouble(Console.ReadLine());
            double a = (double)Math.Pow(radiusValue, 2);
            double bConstant = 3.142;
            double c = a * bConstant;
            Console.WriteLine("the area of circle "+c);

        }
    }
}
