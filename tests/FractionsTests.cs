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
            a = new Fraction(3, 7);
            b = new Fraction(1, 2);
            Assert.Equal(new Fraction(13, 14), a + b);
        }
    }
}
