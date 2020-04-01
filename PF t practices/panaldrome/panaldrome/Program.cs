using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panaldrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ANY WORD");
            string a = Console.ReadLine();
            
            string b = new string (a.Reverse().ToArray());
            Console.WriteLine("YOUR REVERSE IS" + "\n" + b);
            if (a == b)
            {
                Console.WriteLine("panaldrome");
            }
            else
            {
                Console.WriteLine("not panaldrome");
            }
        }
    }
}
