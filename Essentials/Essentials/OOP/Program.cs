using OOP.Polymorphisms;
using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            MainMenu();

            Console.ReadLine();
            Console.Clear();
            Main();
        }

        private static void MainMenu()
        {
            Console.WriteLine(" ------------ Menu ---------------- ");
            Console.WriteLine(" 1 - Polymorphisms ");
            Console.WriteLine(" ---------------------------- ");

            var key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    PolimorphismMenu();
                    break;

                default:
                    NotFoundMessage();
                    break;
            }
        }

        private static void PolimorphismMenu()
        {
            Console.WriteLine(" ------------ SubMenu ---------------- ");
            Console.WriteLine(" A - Polymorphism 1 ");
            Console.WriteLine(" ---------------------------- ");
            var polimorphismKey = Console.ReadLine();

            switch (polimorphismKey.ToLower())
            {
                case "a":
                    Polimorphism1Runner();
                    break;

                default:
                    NotFoundMessage();
                    break;
            }
        }

        private static void Polimorphism1Runner()
        {
            Console.Clear();
            Console.WriteLine(" Polymorphism 1 ");
            Console.WriteLine();
            Polymorphism1.Run();
        }

        private static void NotFoundMessage()
        {
            Console.WriteLine("It was not found. Please press [enter/entre] and try agin.");
        }
    }
}
