using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b=a%2;

            //Console.WriteLine(b);
            const int mask = 1;
    var binary = string.Empty;
            int number=Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                // Logical AND the number and prepend it to the result string
                binary = (number & 1) + binary;
                number = number >> 1;
            }
           
        }
    }
}
