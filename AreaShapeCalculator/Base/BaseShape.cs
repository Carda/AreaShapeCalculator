using AreaShapeCalculator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Base
{
    public abstract class BaseShape
    {
        public double DimX { get; private set; }
        public double DimY { get; private set; }
        protected double Area { get; set; }
        public ShapeTypes Type { get; set; }
        public string ShapeName => Enum.GetName(Type) ?? "";
        private bool IsDimYIncluded { get; set; }


        public abstract double CalculateArea();
        
        public BaseShape(ShapeTypes _type)
        {
            Type = _type;
            DimX= -1;
            DimY= -1;
            Area = -1;
            IsDimYIncluded = Type.Equals(ShapeTypes.Triangle) || Type.Equals(ShapeTypes.Rectangle);
            AppLog<BaseShape>.Log("Null" + ShapeName + " created.!");
        }

        public BaseShape(double dimX, double dimY,ShapeTypes _type)
        {
            Type= _type;
            DimX = dimX;
            DimY = dimY;
            Area = -1;
            IsDimYIncluded = Type.Equals(ShapeTypes.Triangle) || Type.Equals(ShapeTypes.Rectangle);
            AppLog<BaseShape>.Log(ShapeName + " created.!");
        }

        public bool IsDimensionsReady()
        {
            if (IsDimYIncluded)
                return DimX > 0 && DimY > 0;
            else
                return DimX > 0;
        }

        public double GetArea() 
        { 
            return Area;
        }

        public override string ToString()
        {
            return ShapeName + " area calculated : " + Area;
        }

    }
}
