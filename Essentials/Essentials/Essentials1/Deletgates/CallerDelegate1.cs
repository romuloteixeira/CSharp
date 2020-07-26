using Essentials1.Helper;
using System;

namespace Essentials1.Deletgates
{
    public static class CallerDelegate1
    {
        public static void Run()
        {
            Console.WriteLine();
            Delegate1.Del handler = SubscribeDelegate1.DelegateMethod;
            handler("First Delegate Test.");

            NewSubject.WriteLine("Delegate as a parameters - Name: Callback");

            IMyPrint myPrint1 = new MyPrint1();
            SubscribeDelegate1.MethodWithCallback(1, 2, handler, myPrint1);

            NewSubject.WriteLine("Delegate as a parameters - Name: Callback 2");

            IMyPrint myPrint2 = new MyPrint2();
            SubscribeDelegate1.MethodWithCallback(3, 5, handler, myPrint2);
        }
    }

    public class Delegate1
    {
        public delegate void Del(string message);
    }

    public static class SubscribeDelegate1
    {
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void MethodWithCallback(int value1, int value2, Delegate1.Del callback, IMyPrint myPrint)
        {
            int sum = value1 + value2;
            callback($"The sum is: {sum}");

            myPrint.WriteDown($"The sum is: {sum} (same idea)");
        }
    }

    public interface IMyPrint
    {
        void WriteDown(string toPrint)
        {
            Console.WriteLine($"Behavior: Default Interface - Printer interface: {toPrint}");
        }
    }

    public class MyPrint1 : IMyPrint
    {
    }

    public class MyPrint2 : IMyPrint
    {
        public void WriteDown(string toPrint)
        {
            Console.WriteLine($"Behavior: Implametation Method - Do not print the information.");
        }
    }
}
