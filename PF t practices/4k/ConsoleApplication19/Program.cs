using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            // find Celsius by converting ferinheight//
            Console.WriteLine("enter ferinheight value to convert" );
            double f = Convert.ToDouble(Console.ReadLine());
            double a=(f-32);
            double b=0.555555; // 5/9=0.55555 //
            double c=a*b;
            Console.WriteLine("converted value = " + c + "c");
        }
    }
}
