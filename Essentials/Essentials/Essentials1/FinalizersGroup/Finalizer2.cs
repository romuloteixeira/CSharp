using System;
using System.Diagnostics;

namespace Essentials1.FinalizersGroup
{
    class Finalizer2
    {
        Stopwatch stopwatch;

        public Finalizer2()
        {
            stopwatch = new Stopwatch();
            Console.WriteLine("Instantiated object");
        }

        ~Finalizer2()
        {
            Console.WriteLine("Finalizing object");

            stopwatch.Stop();

            Console.WriteLine($"This instance of {this} has been in existence for {stopwatch.Elapsed}");
        }

        public void ShowDuration()
        {
            Console.WriteLine($"This instance of {this} has been in existence for {stopwatch.Elapsed}");
        }
    }
}
