using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_function
{
    class Program
    {
        static void Main(string[] args)
        {    // task reverse function//
            int lenght = 0;
            Console.WriteLine("enter lenght");
            lenght = Convert.ToInt32(Console.ReadLine());

            int[] r = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("enter the value");
                r[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("reverse value is ");
            for (int i = lenght - 1; i >= 0; i--)
            {

                Console.WriteLine(r[i] + ",");
            }
           
           

        }
    }
}
