using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            // find out distance b/w two points//
            Console.WriteLine("enter x1");
            double x1Value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter x2");
            double x2Value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y1");
            double y1Value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y2");
            double y2Value = Convert.ToDouble(Console.ReadLine());
            double a = x2Value - x1Value;
            double b = (double)Math.Pow(a, 2);
            double c = y2Value - y1Value;
            double d = (double)Math.Pow(c, 2);
            double e = b + d;
            double f = Math.Sqrt(e);
            Console.WriteLine("the value of distance b/w two point = "+f);



        }
    }
}
