using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
           //(h) reduced mass = x =? //
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double a = m1 * m2;
            double b = m1 + m2;
            double x= a / b;
            Console.WriteLine("ruduced mass x = "+x);
        }
    }
}
