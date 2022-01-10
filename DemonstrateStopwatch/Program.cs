using System;
using System.Diagnostics;

namespace DemonstrateStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
