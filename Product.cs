using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public static void Main()
        {
            string[][] arr = new string[3][];
            arr[0] = new string[] { "Oreo", "Bour Bon", "Marie Gold" };
            arr[1] = new string[] { "Dairy Milk", "5 Star", "Milky Bar", "Munch", "Park" };
            arr[2] = new string[] { "Margarita", "Moscow Mule", "Martini", "Whiskey Sour", "Dry Martini", "Espresso Martini" };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            } 
        }
    }
}
