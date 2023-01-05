using AreaShapeCalculator.Base;
using AreaShapeCalculator.Shape;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Util
{
    public class CommandParser
    {
        public static CommandParser Instance = new();
        public BaseShape? Shape { get; set; }
        public Commands Command { get; set; }

        public CommandParser() { 
            
        }

        public void Parse(string? commandLine)
        {
            if (!String.IsNullOrEmpty(commandLine))
            {
                Shape = CreateShape(commandLine);
            }

            if (Shape != null)
            {
                Shape.CalculateArea();
                Console.WriteLine(Shape.ToString());
            }
            else
            {
                Console.WriteLine("Shape did not recognised!");
            }            
        }

        public BaseShape? CreateShape(string commandLine)
        {
            object? returnShape = null;
            string[] cWords= commandLine.Split(' ');
            if (cWords.Length < 2)
            {
                AppLog<CommandParser>.Log("Less value than expected!");
                return (BaseShape?)returnShape;
            }
            double dimX = -1;
            double dimY = -1;
            string typeName = Enum.GetNames(typeof(ShapeTypes)).Where(w => w.ToLower() == cWords[0].ToLower()).Select(s => s).FirstOrDefault() ?? string.Empty;

            if (double.TryParse(cWords[1],out dimX))
            {
                if (cWords.Length>2 && double.TryParse(cWords[2],out dimY))
                {
                    AppLog<CommandParser>.Log("Dimensions parsed succesfully.!");
                }
                if (!string.IsNullOrEmpty(typeName))
                {
                    Type objType;
                    try
                    {
                        objType = Type.GetType(Constants.AssemblyName + "." + typeName, true, true);
                        if (typeName.Equals(Enum.GetName(ShapeTypes.Triangle)) || typeName.Equals(Enum.GetName(ShapeTypes.Rectangle)))
                        {
                            returnShape = objType.GetConstructor(new Type[] { typeof(double), typeof(double) }).Invoke(new object[] { dimX, dimY });
                        }
                        else
                        {
                            returnShape = objType.GetConstructor(new Type[] { typeof(double) }).Invoke(new object[] { dimX});
                        }
                    }
                    catch (Exception e)
                    {
                        AppLog<CommandParser>.Log(e.Message);
                    }
                    
                }
            }

            return (BaseShape?)returnShape;            
        }
    }
}
