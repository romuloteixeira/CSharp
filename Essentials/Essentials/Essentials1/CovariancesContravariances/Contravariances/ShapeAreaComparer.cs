using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Essentials1.CovariancesContravariances.Contravariances
{
    public class ShapeAreaComparer : IComparer<Shape>
    {
        int IComparer<Shape>.Compare([AllowNull] Shape shapeA, [AllowNull] Shape shapeB)
        {
            bool hasShapeB = shapeB is not null;
            if (shapeA is null)
            {
                return hasShapeB ? -1 : 0;
            }

            return hasShapeB ? shapeA.Area.CompareTo(shapeB.Area) : 1;
        }
    }
}
