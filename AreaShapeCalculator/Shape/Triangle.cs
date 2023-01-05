using AreaShapeCalculator.Base;
using AreaShapeCalculator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Shape
{
    public class Triangle : BaseShape
    {
        public Triangle() : base(ShapeTypes.Triangle) { }

        public Triangle(double width, double height) : base(width,height,ShapeTypes.Triangle) { }

        public override double CalculateArea()
        {
            if (!IsDimensionsReady())
                return Area;

            Area = (DimX * DimY) / 2;
            AppLog<Triangle>.Log("Triangle area calculated : " + Area);
            return Area;
        }
    }
}
