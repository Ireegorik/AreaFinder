using System;
using Xunit;
using AreaFinder;
namespace AreaFinder.Test
{
    public class CircleTest
    {
        [Fact]
        public void CircleTestRadius()
        {
            // Arrange
            var figure = new Circle("Circle", 25);
            // Act
            float squre = figure.CalcArea();
            // Assert
            Assert.Equal(1962.5, Math.Round(squre,1));
        }
    }
}
