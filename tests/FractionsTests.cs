using System;
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
        }
    }
}
