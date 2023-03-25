using System;
using System.Collections.Generic;
using System.IO;

namespace _9th_Lab
{
    internal class Task1
    {
        public static void Run()
        {
            string path1 = @"./firstGroup.txt";
            string path2 = @"./secondGroup.txt";
            var g1 = Group.Instance(Class1.InitializeStudents(path1, ParseInfo));
            var g2 = Group.Instance(Class1.InitializeStudents(path2, ParseInfo));
            g1.Print();
            g2.Print();
        }

        public static Student ParseInfo(string info)
        {
            var buff = info.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var marks = new List<int>();
            for (int i = 1; i < buff.Length; i++)
            {
                int.TryParse(buff[i], out int mark);
                marks.Add(mark);
            }
            return Student.Instance(buff[0], marks.ToArray());
        }
    }
}
