using System;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_circle()
        {
            mindbox_test.circle circle = new mindbox_test.circle();
            circle.radius = 1;
            Assert.Equal(3.14, circle.square());
            circle.radius = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => circle.square());
        }
        [Fact]
        public void Test_triangle()
        {
            mindbox_test.triangle triangle = new mindbox_test.triangle();
            triangle.a = 3;
            triangle.b = 4;
            triangle.c = 5;
            Assert.Equal(6, triangle.square());
            triangle.a = -3;
            triangle.b = -4;
            triangle.c = -5;
            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.square());
        }
    }
}