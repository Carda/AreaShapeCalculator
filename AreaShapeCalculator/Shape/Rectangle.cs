
using AreaShapeCalculator.Base;
using AreaShapeCalculator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Shape
{
    public class Rectangle : BaseShape
    {
        public Rectangle() : base(ShapeTypes.Rectangle) { }

        public Rectangle(double dimX, double dimY) : base (dimX,dimY, ShapeTypes.Rectangle) { }

        public override double CalculateArea()
        {
            if (!IsDimensionsReady())
                return Area;

            Area = DimX * DimY;
            AppLog<Rectangle>.Log(DimX + "x" + DimY + " Rectangle area calculated : " + Area);
            return Area;
        }
    }
}
