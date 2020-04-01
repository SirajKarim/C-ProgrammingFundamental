using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toghther
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum1 = 0;
            int avg=0 ;
            int max=0;
            int min=0;
            int p_num = 0;
            int n_num = 0;
            int lenght6 = 0;
            int i;
            string rev;

            Console.WriteLine("enter the length of an array");
            int lenght = Convert.ToInt32(Console.ReadLine());
             int[] x = new int[lenght];
              for ( i = 0; i <lenght; i++)
            {
                Console.WriteLine("input any no");
                x[i] = Convert.ToInt32(Console.ReadLine());
                
                sum = sum + x[i];
                
                //task avg//
                  sum1 = sum1 + x[i];
                 
                   avg = sum1 / lenght;

                // task highest no in an array//

               if (max < x[i])
                {
                    max = x[i];
                }

         // task lowest no in an array

            
                if (x[i] < 0)
                {
                    min = x[i];
                }

           // task positive no//
          if (x[i] >= 0)
                {
                    p_num = p_num + 1;


                }


                //// task negitive no//

               if (x[i] < 0)
                {
                    n_num = n_num + 1;
                }
               
             
            }
              Console.Write("Revers Order ");

              for (int j = lenght - 1; j >= 0; j--)
              {


                  Console.Write(x[j] + ",");
                  
              }
              Console.WriteLine();
                Console.WriteLine("sum is " + sum);
                Console.WriteLine("avg is " + avg);
                Console.WriteLine("maximum no is :  " + max);
                Console.WriteLine("minimum no is :  " + min);
                Console.WriteLine("positive no is : "+p_num);
                Console.WriteLine("negitive no is : "+n_num);
               

                
            
        }
    }
}

