using System;

namespace Essentials1.CovariancesContravariances.Contravariances
{
    class Circle : Shape
    {
        public Circle(double radius) => this.Radius = radius;

        public double Radius { get; }

        public override double Area 
        {
            get 
            {
                return Math.PI * Radius * Radius;
            }
        }
    }
}
