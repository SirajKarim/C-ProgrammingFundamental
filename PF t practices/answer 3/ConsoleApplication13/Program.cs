using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            // if married //
            Console.WriteLine("marital status");
            string maritalStatus = Console.ReadLine();

            if (maritalStatus == "married")
            {Console.WriteLine("insured");}
            
            else
            { Console.WriteLine("not sured"); }
                // if unmarried // 
             Console.WriteLine("if unmarried please mention gender and age");
            Console.WriteLine("marital status");
            string maritalStatus1 = Console.ReadLine();
            Console.WriteLine("gender");
            String gender = Console.ReadLine();
            Console.WriteLine("age");
            int age = Convert.ToInt32(Console.ReadLine());
            
              if (gender == "male" && maritalStatus1 == "unmarried" && age>=28)
            { Console.WriteLine("insured"); }
            else if (maritalStatus1 == "unmarried" && gender == "female" && age >= 22)
            { Console.WriteLine("insured"); }
            else
            { Console.WriteLine("not insured"); }
            



        }
    }
}
