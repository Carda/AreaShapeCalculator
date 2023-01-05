
using AreaShapeCalculator.Base;
using AreaShapeCalculator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Shape
{
    public class Square : BaseShape
    {  
        public Square() : base(ShapeTypes.Square) { }

        public Square(double dimX) : base (dimX,-1, ShapeTypes.Square) { }

        public override double CalculateArea()
        {
            if (!IsDimensionsReady())
                return Area;

            Area = DimX * DimX;
            AppLog<Square>.Log("Square area calculated : " + Area);
            return Area;
        }
    }
}
