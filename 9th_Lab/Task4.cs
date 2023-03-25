using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_Lab
{
    internal class Task4
    {
        static int seed = DateTime.Now.Millisecond;
        static Random r;
        public static void Run()
        {
            string path1 = @".\group1.txt";
            string path2 = @".\group2.txt";
            var g1 = Group.Instance(Class1.InitializeSportsmens(path1, ParseInfo));
            var g2 = Group.Instance(Class1.InitializeSportsmens(path2, ParseInfo));
            g1.Print();
            g2.Print();

            var commonGroup = g1.ExpandGroup(g2);
            commonGroup.Print();
        }

        static Sportsmen ParseInfo(string info)
        {
            var buff = info.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int.TryParse(buff[1], out int time);
            return Sportsmen.Instance(buff[0], time);
        }

        public static int GetTime()
        {
            r = new Random(seed);
            return r.Next(1320, 1650);
        }
    }
}
