using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        { // mark sheet //
            Console.WriteLine("english");
            double english = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("maths");
            double maths = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("physics");
            double physics = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("chemistry");
            double chemistry= Convert.ToDouble(Console.ReadLine());
            double a = english + maths + physics + chemistry;
            double b = a * 100;
            double c = b / 400;
            Console.WriteLine("total marks you have achived = "+a );
            Console.WriteLine("percentage = " + c + "%");
        }
    }
}
