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
            // without user input //
            for (int i = 1; i < 6; i++)
            {
                for (int j = 5; j <= 10; j++)
                { Console.Write("# "); }
                Console.WriteLine();
            }
            // with user input //
            Console.WriteLine("no of raws ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many '#' you want  ");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < r; i++)
            {
                for (int j = 1; j <= h; j++)
                { Console.Write("# "); }
                Console.WriteLine();
            }
        }
    }
}
