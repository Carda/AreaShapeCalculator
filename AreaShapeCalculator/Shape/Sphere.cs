using AreaShapeCalculator.Base;
using AreaShapeCalculator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Shape
{
    public class Sphere : BaseShape
    {
        public Sphere() : base(ShapeTypes.Sphere) { }

        public Sphere(double radius) : base (radius,-1,ShapeTypes.Sphere) { }

        public override double CalculateArea()
        {
            if (!IsDimensionsReady())
                return Area;

            Area = 4 * Math.PI * DimX * DimX;
            AppLog<Sphere>.Log("Sphere area calculated : " + Area);
            return Area;
        }
    }
}
