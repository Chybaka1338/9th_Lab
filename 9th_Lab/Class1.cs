using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace _9th_Lab
{
    internal class Class1
    {
        public static string[] ReadFromFile(string path)
        {
            if (!File.Exists(path))
            {
                Process.GetCurrentProcess().Kill();
            }

            var list = new List<string>();
            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            return list.ToArray();
        }
    }
}
