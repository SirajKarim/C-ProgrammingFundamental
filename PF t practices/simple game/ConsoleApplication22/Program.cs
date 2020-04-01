using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {Console.Write("*****"); Console.Write("#####");Console.Write("@@@@@");Console.Write("&&&&&");
        Console.WriteLine("guess the no of any of above signs ");
                int a=Convert.ToInt32(Console.ReadLine());
            string c = Console.ReadLine();
            do while (c=="yes")

            {  
            
                switch (a)
                {
                    case 100:
                        Console.WriteLine("you won stars");
                        break;
                    case 200:
                        Console.WriteLine("you won hash(#)");
                        break;
                    case 300:
                        Console.WriteLine("you won @");
                        break;
                    case 400:
                        Console.WriteLine("you won &");
                        break;
                Console.WriteLine("do you want to play more")
                    c=Console.ReadLine();
                }
            }
            
            }
}

}               

         
             
  
    

