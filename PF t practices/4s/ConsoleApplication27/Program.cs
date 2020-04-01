using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            // total bill//
            Console.WriteLine("chocolates price");
            double chocolatesItem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ice cream price ");
            double iceItem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("fries price");
            double friesItem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("no of chocolates");
            double howManyC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("no of ice cream");
            double howManyI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("no of  fries");
            double howManyF = Convert.ToDouble(Console.ReadLine());
            double a = chocolatesItem * howManyC;
            double b = iceItem * howManyI;
            double c = friesItem * howManyF;
            double d = a + b + c;
            Console.WriteLine("the total amount = "+d + "rupees" );


        }
    }
}
