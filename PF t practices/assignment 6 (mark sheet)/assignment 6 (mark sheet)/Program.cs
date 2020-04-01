using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_6__mark_sheet_
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp1;
            int inpt2;
            Console.WriteLine("length of subject");
            int lenght=Convert.ToInt32(Console.ReadLine());
       

            
            int[] array1=new int [lenght];
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("input no of array1"+i);
                inp1 = Convert.ToInt32(Console.ReadLine());


                for (int j = 0; j < lenght; j++)
                {
                    Console.WriteLine("input no of array2"+j);
                    inpt2 = Convert.ToInt32(Console.ReadLine());
                   
                }
                Console.WriteLine(inp1 + inpt2);
            }
        }
    }
}
