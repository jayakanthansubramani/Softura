using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Travel
    {
        public static void Main()
        {
            Console.WriteLine("Do you have tarvel history: ");
            Console.WriteLine("Give Yes or No");
            string reply = Console.ReadLine();
            if (reply == "Yes")
            {
                Console.WriteLine("Do you have temperature: ");
                string reply1 = Console.ReadLine();
                if(reply1 == "Yes")
                {
                    Console.WriteLine("Do you have cough/sneez: ");
                    string reply2 = Console.ReadLine();
                    if(reply2 == "Yes")
                    {
                        Console.WriteLine("Swab Test");
                    }
                    else
                    {
                        Console.WriteLine("Quarantine,Fever medicine");
                    }
                }
                else
                {
                    Console.WriteLine("Home Quarantine for 28 Days");
                }
            }
            else
            {
                Console.WriteLine("Safe Not COVID-19");
            }
        }
    }
}
