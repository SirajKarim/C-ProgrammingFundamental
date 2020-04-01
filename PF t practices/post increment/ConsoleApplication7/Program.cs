using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 1;
            y = 0;
            y = y + x++;
            Console.WriteLine(y);
            Console.WriteLine( x);


        }
    }
}
