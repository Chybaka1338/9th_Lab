using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_Lab
{
    internal class Class1
    {
        public static string path = @".\persons.txt";

        public static void Me()
        {
            File.Delete(@".\persons.txt");
            Console.WriteLine(File.Exists(@".\persons.txt"));
        }
    }
}
