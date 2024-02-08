using System;
using Xunit;

namespace AreaFinder.Test
{
    public class TriangleTest
    {
        [Fact]
        public void RightTriangleTestAllSidesDifferent()
        {
            // Arrange
            var figure = new Triangle("Triangle", 3,4,5);
            // Act
            float squre = figure.CalcArea();
            // Assert
            Assert.Equal(6, squre);
        }
        [Fact]
        public void TriangleTestAllSidesDifferent()
        {
            // Arrange
            var figure = new Triangle("Triangle", 7, 4, 9);
            // Act
            float squre = figure.CalcArea();
            // Assert
            Assert.Equal(13, Math.Round(squre));
        }
        [Fact]
        public void TriangleTestTwoSidesEquals()
        {
            // Arrange
            var figure = new Triangle("Triangle", 4, 6);
            // Act
            float squre = figure.CalcArea();
            // Assert
            Assert.Equal(8, Math.Ceiling(squre));
        }
        [Fact]
        public void TriangleTestAllSidesEquals()
        {
            // Arrange
            var figure = new Triangle("Triangle", 5);
            // Act
            float squre = figure.CalcArea();
            // Assert
            Assert.Equal(10, Math.Floor(squre));
        }
    }
}
