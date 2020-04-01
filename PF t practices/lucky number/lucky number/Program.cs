using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucky_number
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            char[] array = a.ToCharArray();

            if (array[a.Length - 3] == '7')
            {
                Console.WriteLine("LUCKY");
            }
            else
            {
                Console.WriteLine("unlucky");
            }
               
            
 
        }
    }
}
