using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sorting_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int sort = 0; int a;
            Console.WriteLine("lenght of array");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[input];
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("input no "+i);
                 num[i] = Convert.ToInt32(Console.ReadLine());
               
            
          
            
           
            for (int k = 0;  k< num.Length; i++)
            {
                for (int j = 0; j < num.Length-1; j++)
                {

                    if (num[j] > num[j + 1])
                    {
                        sort = num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = sort;
                    }
                       
                    }
                    
                }
               
            }
            for (int i = 0; i < num.Length; i++)
                Console.WriteLine(num[i] );

           
        }
    }
}
