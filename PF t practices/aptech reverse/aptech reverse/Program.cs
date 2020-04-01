using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aptech_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Console.WriteLine("lenght of array");
            //int input=int.Parse(Console.ReadLine());
            //while (input-->0)
	{


        Console.WriteLine("input your text");
			string text=Console.ReadLine();
            string[] words = text.Split(' ');
           Array.Reverse(words);
           text = String.Join(" ", words);
                Console.WriteLine(text);
            }
        }
    }
}
