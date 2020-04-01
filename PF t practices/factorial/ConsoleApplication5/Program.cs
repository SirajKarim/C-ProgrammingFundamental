using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {



            ////Console.Write("Enter number to find factorial:  ");
            ////int input = Convert.ToInt32(Console.ReadLine());
            ////int factorial = input;
            ////for (int i = 1; i < input; i++)
            ////{
            ////    factorial = factorial * i;
                

            ////}
            //Console.WriteLine(factorial);
         
            ////Console.Write("\n");




            int prime = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 2; i < prime; i++)
            {
                if (prime % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    break;
                }

            }

            if (i == prime)
            {
                Console.WriteLine("Number is Prime");
            }

            else if (prime == 1 || prime == 0)
            {
                Console.WriteLine("0 and 1 are not considered prime");
            }













        }
    }
}