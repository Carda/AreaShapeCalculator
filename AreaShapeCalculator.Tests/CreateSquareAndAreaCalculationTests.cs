using AreaShapeCalculator.Shape;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Tests
{
    [TestFixture]
    public class CreateSquareAndAreaCalculationTests
    {
        Square sq;

        [TestCase(4)]
        [TestCase(236575)]
        [TestCase(234523765648)]
        [TestCase(-124)]
        [TestCase(23)]
        public void CreateSquareSuccesfully(double dimX) 
        {
            sq = new Square(dimX);
            Assert.That(sq, Is.Not.Null);
        }

        [TestCase(4)]
        [TestCase(236575)]
        [TestCase(234523765648)]
        [TestCase(-124)]
        [TestCase(23)]
        public void CreateSquareSuccesfullyAndCalculateAreaSuccessfully(double dimX)
        {
            sq = new Square(dimX); 
            Assert.IsNotNull(sq);
            sq.CalculateArea();
            Assert.That(sq.GetArea(), Is.EqualTo(dimX * dimX));
        }
    }
}
