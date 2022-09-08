using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ElectricityBill
    {
        public static void Main()
        {
            Console.WriteLine("Enter the units used: ");
            int units = Convert.ToInt32(Console.ReadLine());
            if (units <= 200)
            {
                Console.WriteLine(200 * 2);
            }
            else if(units > 200 && units < 350)
            {
                Console.WriteLine(400 + (units - 200) * 3);
            }
            else if(units >= 350 && units < 500)
            {
                Console.WriteLine(850 + ((units - 350) * 5));
            }
            else
            {
                Console.WriteLine(1100 + ((units - 500) * 7));
            }
        }
    }
}
