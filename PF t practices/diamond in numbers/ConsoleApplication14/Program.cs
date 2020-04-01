using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int r = 0; r <= 4; r++)
            {
                for (int s = 1; s <= 4 - r; s++)
                { Console.Write(" "); }

                for (int o = 1; o <= (2 * r) - 1; o++)
                { Console.Write(o); }
                { Console.Write("\n"); }
            }

            for (int r = 1; r <= 3; r++)
            {
                for (int s = 1; s <= r; s++)
                { Console.Write(" "); }

                for (int o = 5; o >= (2 * r) - 1; o--)
                { Console.Write(o); }

                { Console.Write("\n"); }
            }
        }
    }
}

