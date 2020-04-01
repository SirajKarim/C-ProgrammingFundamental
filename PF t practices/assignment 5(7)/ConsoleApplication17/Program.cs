using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {    
            for (int i =    1; i < 6; i++)
            {
                int a = 5;
                for (int j = 1; j <= i; j++)
                { Console.Write(a); a--; }
                { Console.WriteLine(); }
            }

        }
    }
}
