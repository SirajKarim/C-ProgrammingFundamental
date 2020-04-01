using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any no");
            int[] a = new int[10];
         
            for (int i = 0; i <a.Length; i++)
                
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
             
                { for (int j = 2; j < 20; j+=2)
                    Console.WriteLine(a[i]+j);  }

                
			


			 
			}
            }

        }
    }

