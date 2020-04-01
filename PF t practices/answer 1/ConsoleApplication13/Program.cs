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
            Console.WriteLine("imtiaz super store");
            Console.WriteLine("items");
            Console.WriteLine("sugar");
            double sugar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("quantity");
            double qsuger = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("rice");
            double rice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("quantity");
            double qrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("oil");
            double oil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("quantity");
            double qoil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pulses");
            double pulses = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("quantity");
            double qpulses = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("flour");
            double flour = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("quantity");
            double qfloor = Convert.ToDouble(Console.ReadLine());
            double sum = sugar * qsuger+oil*qoil+pulses*qpulses+flour*qfloor + rice * qrice;
            Console.WriteLine(sum);
            Console.WriteLine("bill=Rs. "+sum);
            double discount = sum * 0.1;
            double totalDiscount=sum-discount;
            if (sum >= 5000)
            { Console.WriteLine("with discount=Rs. "+totalDiscount); }

            else
            { Console.WriteLine("no discount=Rs. "+ sum); }
            
            
        }
    }
}
