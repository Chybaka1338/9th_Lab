using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _9th_Lab
{
    internal class Group
    {
        List<Person> _persons;
        double _middle;
        public static Group Instance(List<Person> list)
        {
            Group group = new Group();
            group._persons = list;
            group._middle = 0;
            list.ForEach(item =>
            {
                group._middle += item.GetResult();
            });
            group._middle /= list.Count;
            group.Sort();
            return group;
        }

        private void Sort()
        {
            if (_persons == null || _persons.Count == 0)
            {
                Process.GetCurrentProcess().Kill();
            }

            var type = _persons[0].GetType();
            var reverse = Type.GetType("_9th_Lab.Student") == type ? -1 : 1;
            _persons.Sort((person1, person2) =>
            {
                return person1.GetResult().CompareTo(person2.GetResult()) * reverse;
            });
        }

        public Group ExpandGroup(Group g)
        {
            Group commonGroup = new Group();
            commonGroup._persons = new List<Person>();
            int i = 0;
            int j = 0;
            while (i < _persons.Count && j < g._persons.Count)
            {
                var s = _persons[i].GetResult() < g._persons[j].GetResult() ? _persons[i++] : g._persons[j++];
                commonGroup._persons.Add(s);
            }
            while (i < _persons.Count)
            {
                commonGroup._persons.Add(_persons[i++]);
            }
            while (j < g._persons.Count)
            {
                commonGroup._persons.Add(g._persons[j++]);
            }
            commonGroup._middle = (g._middle + _middle) / 2;

            return commonGroup;
        }

        public void Print()
        {
            Console.WriteLine("Group avg = {0: 0.#}", _middle);
            _persons.ForEach(item =>
            {
                item.Print();
            });
            Console.WriteLine("_______________________");
        }
    }
}
