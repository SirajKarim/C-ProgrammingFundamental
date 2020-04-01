using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6_3rd_task_neg_
{
    class Program
    {
        static void Main(string[] args)
        {
            //// task negitive no//

            Console.WriteLine("input the length");
            
            int n_num = 0;
            int c = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[c];
            for (int i = 0; i < c; i++)
            {Console.WriteLine("input any no");
                array[i] = Convert.ToInt32(Console.ReadLine());
           
            
                if (array[i] <0)
                {
                    n_num=n_num+1;
                }
            }
            Console.WriteLine(n_num);

        }
    }
}
