using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_Lab
{
    abstract class Person
    {
        public readonly string _lastName;

        public Person(string lastName)
        {
            _lastName = lastName;
        }

        abstract public double GetResult();

        abstract public void Print();
    }
}
