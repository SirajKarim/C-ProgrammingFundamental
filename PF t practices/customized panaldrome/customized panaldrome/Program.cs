using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customized_panaldrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "MOHSIN";
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            char[] b = a.ToCharArray();
           char c;
          
            c = b[d];
            b[d] = b[e];
            b[e] = c;
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }
        }
    }
}
