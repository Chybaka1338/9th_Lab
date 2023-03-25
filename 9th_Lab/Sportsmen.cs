using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9th_Lab
{
    delegate Sportsmen ParseSportsmen(string info);
    internal class Sportsmen : Person
    {
        int timeSecond;
        DateTime time;

        private Sportsmen(string lastName) : base(lastName)
        {

        }

        public static Sportsmen Instance(string lastName, int timeSecond)
        {
            Sportsmen sportsmen = new Sportsmen(lastName);
            sportsmen.timeSecond = timeSecond;
            sportsmen.time = new DateTime().AddSeconds(timeSecond);
            return sportsmen;
        }

        override
        public double GetResult()
        {
            return timeSecond;
        }

        override
        public void Print()
        {
            Console.WriteLine("{0} {1:mm:ss}", _lastName, time);
        }
    }
}
