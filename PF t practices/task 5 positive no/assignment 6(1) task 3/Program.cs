using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6_1__task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// task positive no//
           
            Console.WriteLine("input the length");
            int p_num = 0;
           
            int c = Convert.ToInt32(Console.ReadLine());
            int[] array= new int[c];
            for (int i = 1; i < c; i++)
            {Console.WriteLine("input any no");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i]>=0)
                {
                    p_num = p_num + 1;
                    
                    
                }
           }
            Console.WriteLine(p_num);
            

        }
    }
}
