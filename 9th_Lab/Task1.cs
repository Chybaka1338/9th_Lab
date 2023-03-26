using System;
using System.Collections.Generic;

namespace _9th_Lab
{
    internal class Task1
    {
        public static void Run(string[] paths)
        {
            var groups = new List<Group>();
            foreach(var path in paths)
            {
                groups.Add(Group.Instance(GetList(Class1.ReadFromFile(path))));
            }

            groups.Sort();
            foreach(var group in groups)
            {
                group.Print();
            }
        }

        public static List<Person> GetList(string[] lines)
        {
            var list = new List<Person>();
            foreach (var line in lines)
            {
                list.Add(ParseInfo(line));
            }
            return list;
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
