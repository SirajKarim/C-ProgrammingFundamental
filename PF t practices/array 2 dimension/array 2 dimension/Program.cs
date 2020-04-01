using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_2_dimension
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("lenth1");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lenth2");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[ ,] num = new int[size1,size2];
            Console.WriteLine("user input");
            for ( i = 0; i < size1; i++)
            {
                for (j = 0; j < size2; j++)
                    
                {
                    num[i,j]=Convert.ToInt32(Console.ReadLine());
                    
                }
                Console.WriteLine(num[i, j]);
            }


            

           

        }
    }
}
