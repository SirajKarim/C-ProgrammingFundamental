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
            for (int i = 1; i <= 3; i++)
            {
                for (int space = 5; space >= i; space--)
                { Console.Write(" "); }


                for (int n = 1; n<=i ; n++)
                { Console.Write(n+" "); }
                Console.WriteLine();
            }
           
            
                for (int i = 1; i <= 2; i++)
                {
                    for (int space = -2; space <= i; space++)
                    { Console.Write(" "); }
                    int l = 1;
                    for (int n = 2; n>=i; n--)
                    { Console.Write(l+" "); l++; }
                    { Console.WriteLine(); }
                }
                
            }
        }
    }

