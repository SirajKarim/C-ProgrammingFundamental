using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            bool done = false;
            for (i = 0, j = 100; !done; i++, j--)
            {
                if (i * i > j)
                {
                    done = true;
                }
                Console.WriteLine("i,j" + i + j);
            }

            

        }
    }
}
