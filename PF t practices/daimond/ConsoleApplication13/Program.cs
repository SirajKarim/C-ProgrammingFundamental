using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for(int s=4; s>=r; s--)
                { Console.Write(" "); }

                    for (int o = 1; o<=(2*r)-1; o ++)
                     { Console.Write("#"); }
                    { Console.Write("\n"); }
            }
            for (int r = 1; r <= 4; r++)
            {
                for (int s = 1; s <= r ; s++)
                { Console.Write(" "); }

                for (int o =7 ; o>=(2*r)-1; o--)
                { Console.Write("#");}

                //Console.WriteLine();
               

            }
        }
    }
}
