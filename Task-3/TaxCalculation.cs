using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class calcvat
    {
        public void ClaculateTax(double num1)
        {
            Console.WriteLine("You Need To Pay This Amount  As A tax:  {0}", num1 * 0.2);
        }
    }
    class gst : calcvat
    {
        public void Calculategst(double num1)
        {
            Console.WriteLine("You Need To Pay this Amount As Gst:  {0}", num1 * 0.12);
        }
         
      
    }

    internal class TaxCalculation
    {
        public static void Main()
        {
            public static void Main()
        {
            gst obj1 = new gst();
            Console.WriteLine("Enter The Amount You nedd To Calculate Tax vat"  );
            double rupees = Convert.ToInt32(Console.ReadLine());
            obj1.ClaculateTax(rupees);
            Console.WriteLine("Enter The Amount You nedd To Calculate Tax gst");
            double rupees1 = Convert.ToInt32(Console.ReadLine());
            obj1.Calculategst(rupees1);

        }
        }
    }
}
