using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Switch
    {
        public static void Main()
        {
            Console.WriteLine("Enter the package name: ");
            Console.WriteLine("Choose A or B or C");
            char package = Console.ReadLine()[0];
            switch(package)
            {
                case 'A': Console.WriteLine(" *south special \n *Children's Club \n *Movies \n PRICE: 250");
                break;
                case 'B':Console.WriteLine(" *News \n *Sports \n *Movies \n *Regional-2 \n PRICE: 450");
                break;
                case 'C':Console.WriteLine(" *Discovery,History,National \n PRICE: 350");
                break;
                default: Console.WriteLine("Enter a Valid Input");
                break;

            }
        }
    }
}
