using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_5_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5 ; i++)
            {
                for (int s = 4; s >= i; s--)
                {
                    Console.Write(" ");
                }
                for (int n = 1; n>=2-i;n-- )
                { Console.Write("* "); }
                { Console.WriteLine(); }
            }
        }
    }
}
