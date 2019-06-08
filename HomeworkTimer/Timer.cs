using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HomeworkTimer
{
    class Timer
    {
        //public delegate void Print<T>(T value);
        static Stopwatch stopwatch = new Stopwatch();

        public Timer(int seconds, Action print)
        {
            stopwatch.Start();
            Console.WriteLine("Method will now begin executing. Press any key to quit at any time...");
            while (!Console.KeyAvailable)
            {
                if (stopwatch.ElapsedMilliseconds == seconds * 1000)
                {
                    Console.Write($"Method executed at {DateTime.Now} - Output: ");
                    print();
                    stopwatch.Restart();
                }
                // do something
            }
        }
    }
}
