using System;

namespace Essentials1.Helper
{
    public static class NewSubject
    {
        public static void WriteLine(string name)
        {
            Console.Clear();
            Console.WriteLine($" ----------     {name}     ----------");
            Console.WriteLine();
        }
    }

    public static class Menu
    {
        public static void MenuWriteLine() => WriteLine("Menu");
        public static void SubMenuWriteLine() => WriteLine("SubMenu");
        private static void WriteLine(string title) => Console.WriteLine($" *************     {title}      *************");
        
        public static void EndMenuWriteLine() => Console.WriteLine(" ---------------------------- ");
    }
}
