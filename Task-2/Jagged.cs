using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Jagged
    {
        public static void Main()
        {
            string[][] patient = new string[3][];
            patient[0] = new string[] { "Jai", "Dev", "Vikram" };
            patient[1] = new string[] { "Yuvraj", "Vimal", "Vijay", "Diya" };
            patient[2] = new string[] { "Nithya", "Riyaz", "Vix", "Raj", "Rajasekar", "Sekar" };
            
            for (int i = 0; i < patient.Length; i++)
            {
                for (int j = 0; j < patient[i].Length; j++)
                {
                    Console.WriteLine(patient[i][j]);
                }
            }
        }
    }
}
