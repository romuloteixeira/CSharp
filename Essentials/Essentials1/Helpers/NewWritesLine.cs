using Essentials1.Helpers.Extension;
using System;

namespace Essentials1.Helpers
{
    public static class NewSubject
    {
        public static void WriteLine(string name)
        {
            Console.Clear();
            $" ----------     {name}     ----------".WriteLine();
            Console.WriteLine();
        }
    }

    public static class Menu
    {
        public static void MenuWriteLine() => WriteLine("Menu");
        public static void SubMenuWriteLine() => WriteLine("SubMenu");
        private static void WriteLine(string title) => $" *************     {title}      *************".WriteLine();
        
        public static void EndMenuWriteLine() => " ---------------------------- ".WriteLine();
    }
}
