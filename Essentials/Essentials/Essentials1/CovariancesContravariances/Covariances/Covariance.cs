using System;
using System.Collections.Generic;

namespace Essentials1.CovariancesContravariances.Covariances
{
    public static class Covariance
    {
        public static void Run()
        {
            Derived.Run();
        }
    }

    class Base
    {
        public static  void PrintBases(IEnumerable<Base> bases)
        {
            foreach (Base b in bases)
            {
                Console.WriteLine(b);
            }
        }
    }

    class Derived : Base
    {
        public static void Run()
        {
            var dList = new List<Derived>();
            Derived.PrintBases(dList);
            IEnumerable<Base> bIEnum = dList;
        }
    }
}
