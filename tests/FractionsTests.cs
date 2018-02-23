using System;
using src;
using Xunit;

namespace FractionsUnitTests
{
    public class FractionsTests
    {
        [Fact]
        public void Should_Add()
        {
            var a = new Fraction(1, 2);
            var b = new Fraction(1, 4);
            Assert.Equal(new Fraction(3, 4), a + b);
            a = new Fraction(1, 4);
            b = new Fraction(1, 4);
            Assert.Equal(new Fraction(1, 2), a + b);
            a = new Fraction(5, 6);
            b = new Fraction(1, 4);
            Assert.Equal(new Fraction(13, 12), a + b);
            a = new Fraction(7, 1);
            b = new Fraction(2, 9);
            Assert.Equal(new Fraction(65, 9), a + b);
            a = new Fraction(7, 1);
            b = new Fraction(5, 1);
            Assert.Equal(new Fraction(12, 1), a + b);
        }
    }
}
