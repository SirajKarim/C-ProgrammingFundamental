using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input salery");
            // less than 15000 //
            double basicSal = Convert.ToDouble(Console.ReadLine());
            double rentALLOWNCE = basicSal * 0.01;
            double diningALLOWNCE = basicSal *0.9;
            double allownce1 = rentALLOWNCE + diningALLOWNCE;
            double grossSalary = basicSal + allownce1;
            // 15000 to 20000 //
            double rentALLOWNCE1=500;
            double diningALLOWNCE1=basicSal*0.98;
            double allownces2=rentALLOWNCE1+diningALLOWNCE1;
            double grossSalary1 = basicSal + allownces2;
            
            if (basicSal<=15000)
            { Console.WriteLine("gross salary=Rs. "+grossSalary); }
            else if (basicSal >= 15000 && basicSal <= 20000)
            { Console.WriteLine("gross salary=Rs. "+grossSalary1); }
            
            

            
         

        }
    }
}
