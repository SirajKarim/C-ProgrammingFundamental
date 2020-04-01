using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
        // (j) zakaat //
            Console.WriteLine("enter total amount of zakat");
            double amount = Convert.ToDouble(Console.ReadLine());
            double a = amount * 2.5;
            double b = a / 100;
            Console.WriteLine("total zakat you have to pay= "+b +"rupees");

        }
    }
}
