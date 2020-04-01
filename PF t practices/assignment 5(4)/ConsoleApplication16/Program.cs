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
        {   // first part of triangle design//
            //char g= 'A';
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int space = 5; space >= i; space--)
            //    { Console.Write(" "); }


            //    for (int n = 1; n <= 2 * i - 1; n++)
            //    {
            //        g = g + 1;
            //        Console.Write(g); 
          
            //    }
            //    Console.WriteLine();
            //}

            // second part of triangle//
            for (int i = 2; i >= 1; i--)
            {
                for (int space = 5; space >= i; space--)
                { Console.Write(" "); }

                for (int n = 1; n <= 2 * i - 1; n++)
                {
                    Console.Write((char)(n + 96));

                }
                { Console.WriteLine(); }
            }
            //design  *************** //
            for (int i = 0; i < 1; i++)
            {
                for (int j = 10; j >= i; j--)
                { Console.Write("*"); }
                { Console.WriteLine(); }
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int space = 5; space >= i; space--)
                { Console.Write(" "); }


                for (int n = 1; n <= 2 * i - 1; n++)
                {
                    Console.Write((char)
                        (n + 96));
                }
                Console.WriteLine();
            }

            // second part of triangle//
            for (int i = 2; i >= 1; i--)
            {
                for (int space = 5; space >= i; space--)
                { Console.Write(" "); }

                for (int n = 1; n <= 2 * i - 1; n++)
                {
                    Console.Write((char)(n + 96));

                }
                { Console.WriteLine(); }
            }






        }
    }
}
