using System;

namespace S2_Ex3
{
    public struct Time
    {
        private int minutes;

        public Time(int minutes, int hours)
        {
            this.minutes = minutes + 60 * hours;
        }

        public int Hour => (minutes / 60) % 24;

        public int Minute => minutes % 60;

        public void AddMinutes(int minutes)
        {
            this.minutes += minutes;
        }

        public void SubtractMinutes(int minutes)
        {
            this.minutes -= minutes;
        }

        public override string ToString()
        {
            return $"{Hour}:{Minute.ToString("D2")}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(45, 23);
            Console.Out.WriteLine(time.ToString());
            Time time2 = new Time(20, 10);
            Console.Out.WriteLine(time2.ToString());
            time2.AddMinutes(60);
            Console.Out.WriteLine(time2.ToString());
            time.AddMinutes(80);
            Console.Out.WriteLine(time.ToString());
        }
    }
}