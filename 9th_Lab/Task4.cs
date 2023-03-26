using System;
using System.Collections.Generic;

namespace _9th_Lab
{
    internal class Task4
    {
        static int seed = DateTime.Now.Millisecond;
        static Random r;
        public static void Run(string[] paths)
        {
            var groups = new List<Group>();
            foreach(var path in paths)
            {
                groups.Add(Group.Instance(GetList(Class1.ReadFromFile(path))));
            }

            groups.ForEach(group => group.Print());

            var commonGroup = new Group();
            for (int i = 0; i < groups.Count - 1; i++)
            {
                commonGroup = groups[i].ExpandGroup(groups[i + 1]);
            }

            commonGroup.Print();
        }

        static Sportsmen ParseInfo(string info)
        {
            var buff = info.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int.TryParse(buff[1], out int time);
            return Sportsmen.Instance(buff[0], time);
        }

        static List<Person> GetList(string[] lines)
        {
            var list = new List<Person>();
            foreach (var line in lines)
            {
                list.Add(ParseInfo(line));
            }
            return list;
        }

        public static int GetTime()
        {
            r = new Random(seed);
            return r.Next(1320, 1650);
        }
    }
}
