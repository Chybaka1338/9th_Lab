using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _9th_Lab
{
    internal class Group : IComparable
    {
        List<Person> _persons;
        double _middle;

        public double Middle { get { return _middle; } }

        public static Group Instance(List<Person> list)
        {
            Group group = new Group();
            group._persons = list;
            group._middle = 0;
            list.ForEach(item => group._middle += item is Student student ? student.Middle : 0);
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

            _persons.Sort();
        }

        public Group ExpandGroup(Group g)
        {
            Group commonGroup = new Group();
            commonGroup._persons = new List<Person>();
            int i = 0;
            int j = 0;
            while (i < _persons.Count && j < g._persons.Count)
            {
                if (_persons[i].CompareTo(g._persons[j]) == -1)
                    commonGroup._persons.Add(_persons[i++]);
                else
                    commonGroup._persons.Add(g._persons[j++]);
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

        public int CompareTo(object obj)
        {
            if (obj is Group g) return _middle.CompareTo(g._middle) * (-1);
            else throw new ArgumentException("invalid type");
        }
    }
}
