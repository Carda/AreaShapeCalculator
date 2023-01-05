using AreaShapeCalculator.Shape;
using AreaShapeCalculator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Tests
{
    [TestFixture]
    public class ParseCommandLineTests
    {
        [TestCase("Square 10")]
        [TestCase("square 10")]
        [TestCase("Square 1045345")]
        [TestCase("Square 10345 5345")]
        [TestCase("Square 1023425")]
        public void ParseAndCreateSquareSuccessfully(string cLine)
        {
            Base.BaseShape shape = CommandParser.Instance.CreateShape(cLine);
            Assert.That(shape.ShapeName, Is.EqualTo("Square"));
        }

        [TestCase("Triangle 10")]
        [TestCase("Triangle 10")]
        [TestCase("Triangle 1045345")]
        [TestCase("Triangle 10345 5345")]
        [TestCase("Triangle 1023425")]
        public void ParseAndCreateTriangleSuccessfully(string cLine)
        {
            Base.BaseShape shape = CommandParser.Instance.CreateShape(cLine);
            Assert.That(shape.ShapeName, Is.EqualTo("Triangle"));
        }
    }
}
