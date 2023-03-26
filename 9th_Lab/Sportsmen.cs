using System;

namespace _9th_Lab
{
    delegate Sportsmen ParseSportsmen(string info);
    internal class Sportsmen : Person
    {
        int _timeSecond;
        DateTime _time;

        public int Time { get { return _timeSecond; } }

        private Sportsmen(string lastName) : base(lastName)
        {

        }

        public static Sportsmen Instance(string lastName, int timeSecond)
        {
            Sportsmen sportsmen = new Sportsmen(lastName);
            sportsmen._timeSecond = timeSecond;
            sportsmen._time = new DateTime().AddSeconds(timeSecond);
            return sportsmen;
        }

        override
        public void Print()
        {
            Console.WriteLine("{0} {1:mm:ss}", _lastName, _time);
        }

        override
        public int CompareTo(object obj)
        {
            if (obj is Sportsmen sportsmen) return _timeSecond.CompareTo(sportsmen._timeSecond);
            else throw new ArgumentException("invalid type");
        }
    }
}
