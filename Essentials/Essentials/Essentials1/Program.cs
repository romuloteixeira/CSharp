using Essentials1.Deletgates;
using Essentials1.FinalizersGroup;
using Essentials1.Helper;
using Essentials1.Indexers;
using System;

namespace Essentials1
{
    class Program
    {
        static void Main(string[] args)
        {
            StructVsClass.Run();

            Finalizer();
            Nested();
            Indexer();
            Delegaters();
        }

        private static void Delegaters()
        {
            NewSubject.WriteLine(nameof(Delegate1));
            CallerDelegate1.Run();
        }

        private static void Indexer()
        {
            FirstIndexer();
            SecondIndexer();
        }

        private static void SecondIndexer()
        {
            var count = 0;
            var myStringCollection = new Indexer2<string>();
            myStringCollection.Add($"My Test {++count}");
            myStringCollection.Add($"My Test {++count}");

            Console.WriteLine();
            Console.WriteLine($" *************     {nameof(Indexer2<string>)}       **********************");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"myStringCollection {i}: {myStringCollection[i]}");
            }
        }

        private static void FirstIndexer()
        {
            var count = 0;
            var myStringCollection = new Indexer1<string>();
            myStringCollection[count++] = $"My Test {count}";
            myStringCollection[count++] = $"My Test {count}";

            NewSubject.WriteLine(nameof(Indexer1<string>));
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"myStringCollection {i}: {myStringCollection[i]}");
            }

        }

        private static void Nested()
        {
            var nestedClass = new NestedClass.Nested
            {
                Value = 1
            };

            Console.WriteLine();
            Console.WriteLine(nestedClass.ToString());
        }

        private static void Finalizer()
        {
            Finalizers.Run();
            //var thirdClassFinalizer = new ThirdClassFinalizer();
            var finalizer2 = new Finalizer2();
            finalizer2.ShowDuration();

            ExampleClass ex = new ExampleClass();
            ex.ShowDuration();
        }
    }
}
