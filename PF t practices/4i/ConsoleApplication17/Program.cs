using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            //(i) newton gravity //
            Console.WriteLine("enter m1 = ");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter m2 = ");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter radius = ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(6.63 * (Math.Pow(10, -11)));
            double a = g * m1 * m2;
            double b = (double)Math.Pow(radius, 2);
            double c = a / b;
            Console.WriteLine("the value of G = "+c);


           

        }
    }
}
