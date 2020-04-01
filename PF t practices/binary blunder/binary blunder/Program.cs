using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_blunder
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Int32.Parse(Console.ReadLine());
            string binaryNum = Console.ReadLine();

            string binary = Convert.ToString(value, 2);
            if (binaryNum == binary)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("UnCorrect");
            }
        }
    }
}
