
using AreaShapeCalculator.Base;
using AreaShapeCalculator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Shape
{
    public class Circle : BaseShape
    {   
        public Circle() : base(ShapeTypes.Circle) { }

        public Circle(double radius) : base(radius,-1,ShapeTypes.Circle) { }

        public override double CalculateArea()
        {
            if (!IsDimensionsReady())
            {
                return Area;
            }

            Area = Math.PI * DimX * DimX;
            AppLog<Circle>.Log("Circle area calculated : " + Area);
            return Area;
        }
    }
}
