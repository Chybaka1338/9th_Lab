using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace _9th_Lab
{
    internal class Class1
    {
        public static List<Person> InitializeStudents(string path, ParseStudent Parser)
        {
            if (!File.Exists(path))
            {
                Process.GetCurrentProcess().Kill();
            }

            var students = new List<Person>();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        students.Add(Parser.Invoke(line));
                    }
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return students;
        }

        public static List<Person> InitializeSportsmens(string path, ParseSportsmen Parser)
        {
            if (!File.Exists(path))
            {
                Process.GetCurrentProcess().Kill();
            }

            var students = new List<Person>();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        students.Add(Parser.Invoke(line));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return students;
        }
    }
}
