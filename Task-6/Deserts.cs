using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Deserts
    {
        public static void Main()
        {
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            dic.Add("Banana Spring Rolls", "P.F. Chang's");
            dic.Add("Molten Chocolate Cake", "Chili's");
            dic.Add("Key Lime Pie", "Bonefish Grill");

            
            
            FileStream fs = new FileStream("C:\\practice\\Day-2 c sharp\\Deaserts.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new(fs);
            foreach (object obj in dic)
            {
                sw.WriteLine(obj);
            }
            sw.Flush();
            sw.Close();
            Console.WriteLine("Done!");

            FileStream fs1 = new FileStream("C:\\practice\\Day-2 c sharp\\Deaserts.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            Console.WriteLine(sr.ReadToEnd());
            FileInfo fi = new FileInfo("C:\\practice\\Day - 2 c sharp\\Deaserts.txt");
             Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.CreationTime);
            long size = fi.Length;
            Console.WriteLine("File Size in Bytes: {0}", size);
        }
    }
}
