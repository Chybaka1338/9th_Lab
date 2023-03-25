using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _9th_Lab
{
    delegate Student ParseStudent(string info);

    internal class Student : Person
    {
        int[] _marks;
        double _middleScore;
        
        public double Middle { get { return _middleScore; } }

        private Student(string lastName) : base(lastName)
        {

        }

        public static Student Instance(string lastName, int[] marks)
        {
            Student student = new Student(lastName);
            student._marks = marks;
            student._middleScore = 0;
            Array.ForEach(marks, (mark) =>
            {
                student._middleScore += mark;
            });
            student._middleScore /= marks.Length;
            return student;
        }

        override
        public double GetResult()
        {
            return _middleScore;
        }

        override
        public void Print()
        {
            Console.Write($"{_lastName}: ");
            foreach(var mark in _marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
        }
    }
}
