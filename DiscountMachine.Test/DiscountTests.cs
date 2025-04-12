using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscountMachine.Test
{
    public class DiscountTests
    {
        [Theory]
        [InlineData(0, 1)]
        [InlineData(100, 3)]
        [InlineData(200, 5)]
        [InlineData(500, 10)]
        public void CalculateDiscount_ValidPoints_ReturnsExpected(int points, int expected)
        {
            var result = DiscountCalculator.CalculateDiscount(points);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateDiscount_NegativePoints_Throws()
        {
            Assert.Throws<ArgumentException>(() => DiscountCalculator.CalculateDiscount(-10));
        }
    }
}
