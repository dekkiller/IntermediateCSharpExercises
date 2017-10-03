using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Section1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch.Start();
            Thread.Sleep(5000);
            Stopwatch.End();
            Console.WriteLine(Stopwatch.Duration);
        }
    }
}
