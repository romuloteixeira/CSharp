//#define DEBUG
using System;
using System.Diagnostics;

namespace Essentials1
{
    public static class Finalizers
    {
        public static void Run()
        {
            //var structFinalizerError = new StructFinalizerError();
            var thirdClassFinalizer = new ThirdClassFinalizer();
        }
    }

    struct StructFinalizerError
    {
        //~StructFinlizersError()
        //{
        //    System.Diagnostics.Trace.WriteLine("Do not work.");
        //}
    }

    class FirstClassFinalizer
    {
        ~FirstClassFinalizer() => Writer();

        private void Writer()
        {
            TraceWriter();
            ConsoleWriter();
        }

        private static void ConsoleWriter()
        {
            Console.WriteLine("First's destructor is called.");
        }

        private static void TraceWriter()
        {
            System.Diagnostics.Trace.WriteLine("First's destructor is called.");
            Debug.WriteLine("First's destructor is called.");
        }
    }

    class SecondClassFinalizer : FirstClassFinalizer
    {
        ~SecondClassFinalizer() => System.Diagnostics.Trace.WriteLine("Second's destructor is called.");
    }

    class ThirdClassFinalizer : SecondClassFinalizer
    {
        ~ThirdClassFinalizer() => Trace.WriteLine("Third's destructor is called.");
    }
}
