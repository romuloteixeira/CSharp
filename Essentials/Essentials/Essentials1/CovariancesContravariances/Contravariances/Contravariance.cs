using System;
using System.Collections.Generic;

namespace Essentials1.CovariancesContravariances.Contravariances
{
    public static class Contravariance
    {
        public static void Run()
        {
            const double FirstRadius = 7.2;
            const int SecondRadius = 100;
            const double ThirdRadius = .01;
            Console.WriteLine($"FirstRadius: {FirstRadius}, SecondRadius: {SecondRadius}, ThirdRadius: {ThirdRadius}");
            Console.WriteLine();

            var circlesByArea = new SortedSet<Circle>(new ShapeAreaComparer())
            {
                new Circle(FirstRadius),
                new Circle(SecondRadius),
                new Circle(ThirdRadius),
            };

            foreach (var circle in circlesByArea)
            {
                Console.WriteLine(circle is null ? "null" : $"Circle wirth area: {circle.Area}");
            }
        }   
    }
}
