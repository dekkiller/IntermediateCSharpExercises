using System;

namespace Section1_2
{
    static class Stopwatch
    {
        public static TimeSpan Duration { get; private set; }
        private static DateTime? _startTime = null;
        private static DateTime? StartTime
        {
            get
            {
                Console.WriteLine("In getter");
                return _startTime;
            }
            set
            {
                Console.WriteLine("In setter");
                if (_startTime != null)
                {
                    throw new InvalidOperationException("Can't call stopwatch twice without stopping!");
                }
                else
                {
                    _startTime = value;
                }
            }
        }
        //private static DateTime EndTime { get; set; }


        public static void Start()
        {
            Console.WriteLine("Started Stopwatch.");
            StartTime = DateTime.Now;
        }

        public static void End()
        {
            Console.WriteLine("Ended Stopwatch.");
            Duration = DateTime.Now.Subtract(StartTime.Value);

        }


    }
}