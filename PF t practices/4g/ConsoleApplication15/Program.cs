using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            //(g) result = x = ? //
            Console.WriteLine("enter the value of x");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = x + (double)Math.Pow(x, 2) * (double)Math.Pow(x, 3);
            double b= (double)Math.Pow(x,2);
            double c = x % (double)Math.Pow(x, 2);
            double d = x * 3;
            double e = a / b;
            double f = c / d;
            double g = e - f;
            Console.WriteLine("final resuly of x = "+g );



        }
    }
}
