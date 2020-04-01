using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        { //(n) find out En //
            Console.WriteLine(" enter hydrogen state");
            double hState = Convert.ToDouble(Console.ReadLine());
            double a = (double)Math.Pow(hState, 2);
            double b = 1 / a;
            double c = Convert.ToDouble(2.18 * (Math.Pow(10, -18)));
            double d = -c * b;
            Console.WriteLine("the value of En =   "+d+ "joules");

        }
    }
}
