using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = i; j >= i; j--)
                { Console.WriteLine(" "); }
                for (int k = i; k >= 5; k++)
                { Console.Write("*"); }
                { Console.WriteLine(); }
            }
        }
    }
}
