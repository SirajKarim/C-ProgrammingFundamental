using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            //find area of Trapezoid //
            Console.WriteLine("enter base1");
            double base1Value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter base2");
            double base2Value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter hieght");
            double hieghtValue = Convert.ToDouble(Console.ReadLine());
            
            double a = base1Value + base2Value;
            double b = a * hieghtValue;
            double c = 0.5;
            double d = b * c;
            Console.WriteLine("the area of trapezoid = "+d);

        }
    }
}
