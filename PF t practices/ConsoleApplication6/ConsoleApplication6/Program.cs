using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the lenght of table");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=a; i++)
            {
                Console.WriteLine("input which table you want to print");
                
                int table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("table of : " + table);
                for (int j = 1; j <= 10; j++)
                {
                    
                    Console.WriteLine(table+"*"+j+ "=" + j*table);
                }
            }
        }
    }
}
