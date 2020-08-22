using Essentials1.CovariancesContravariances.Contravariances;
using Essentials1.CovariancesContravariances.Covariances;
using Essentials1.Deletgates;
using Essentials1.FinalizersGroup;
using Essentials1.Helper;
using Essentials1.Indexers;
using System;

namespace Essentials1
{
    class Program
    {
        static void Main()
        {
            MenuMain();
            
            Console.ReadLine();
            Console.Clear();

            Main();
        }

        private static void MenuMain()
        {
            Menu.MenuWriteLine();
            Console.WriteLine(" 1 - Struct Vs Class ");
            Console.WriteLine(" 2 - Finalizers ");
            Console.WriteLine(" 3 - Nested ");
            Console.WriteLine(" 4 - Indexers ");
            Console.WriteLine(" 5 - Indexers ");
            Console.WriteLine(" 6 - Covariance and Contravariance ");
            Menu.EndMenuWriteLine();
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    StructVsClassRunner();
                    break;

                case "2":
                    FinalizerRunner();
                    break;

                case "3":
                    NestedRunner();
                    break;

                case "4":
                    MenuIndexers();
                    break;

                case "5":
                    MenuDelegate();
                    break;

                case "6":
                    CovarianceContracovarianceMenu();
                    break;

                default:
                    NotFoundMessage();
                    break;
            }
        }

        private static void CovarianceContracovarianceMenu()
        {
            Menu.SubMenuWriteLine();
            Console.WriteLine(" A - Covariance in Generic ");
            Console.WriteLine(" B - Contracovariance in Generic ");
            Menu.EndMenuWriteLine();

            var option = Console.ReadLine();

            switch (option.ToLower())
            {
                case "a":
                    CovarianceRunner();
                    break;

                case "b":
                    ContravarianceRunner();
                    break;

                default:
                    NotFoundMessage();
                    break;
            }
        }

        private static void CovarianceRunner()
        {
            NewSubject.WriteLine("Covariance");
            Covariance.Run();
        }

        private static void ContravarianceRunner()
        {
            NewSubject.WriteLine("Covariance");
            Contravariance.Run();
        }

        private static void MenuIndexers()
        {
            Menu.SubMenuWriteLine();
            Console.WriteLine(" A - First Indexer ");
            Console.WriteLine(" B - Second Indexer ");
            Menu.EndMenuWriteLine();

            var option = Console.ReadLine();

            switch (option.ToLower())
            {
                case "a":
                    FirstIndexerRunner();
                    break;

                case "b":
                    SecondIndexerRunner();
                    break;

                default:
                    NotFoundMessage();
                    break;
            }
        }

        private static void SecondIndexerRunner()
        {
            NewSubject.WriteLine(nameof(Indexer2<string>));

            var count = 0;
            var myStringCollection = new Indexer2<string>();
            myStringCollection.Add($"My Test {++count}");
            myStringCollection.Add($"My Test {++count}");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"myStringCollection {i}: {myStringCollection[i]}");
            }
        }

        private static void FirstIndexerRunner()
        {
            NewSubject.WriteLine(nameof(Indexer1<string>));

            var count = 0;
            var myStringCollection = new Indexer1<string>();
            myStringCollection[count++] = $"My Test {count}";
            myStringCollection[count++] = $"My Test {count}";

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"myStringCollection {i}: {myStringCollection[i]}");
            }

        }

        private static void MenuDelegate()
        {
            Menu.SubMenuWriteLine();
            Console.WriteLine(" A - Delegater 1 ");
            Menu.EndMenuWriteLine();

            var option = Console.ReadLine();

            switch (option.ToLower())
            {
                case "a":
                    Delegater1Runner();
                    break;

                default:
                    NotFoundMessage();
                    break;
            }
        }

        private static void Delegater1Runner()
        {
            NewSubject.WriteLine(nameof(Delegate1));
            Delegate1Caller.Run();
        }

        private static void StructVsClassRunner()
        {
            NewSubject.WriteLine("Struct Vs Class");
            StructVsClass.Run();
        }

        private static void NestedRunner()
        {
            NewSubject.WriteLine("Nested");

            var nestedClass = new NestedClass.Nested
            {
                Value = 1
            };

            Console.WriteLine();
            Console.WriteLine(nestedClass.ToString());
        }

        private static void FinalizerRunner()
        {
            NewSubject.WriteLine("Finalizer");

            Finalizers.Run();
            //var thirdClassFinalizer = new ThirdClassFinalizer();
            var finalizer2 = new Finalizer2();
            finalizer2.ShowDuration();

            ExampleClass ex = new ExampleClass();
            ex.ShowDuration();
        }

        private static void NotFoundMessage()
        {
            Console.WriteLine("It was not found. Please press [enter/entre] and try agin.");
        }
    }
}
