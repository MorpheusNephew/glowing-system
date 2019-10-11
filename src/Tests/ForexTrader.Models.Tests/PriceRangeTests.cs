using Xunit;

namespace ForexTrader.Models.Tests
{
    public class PriceRangeTests
    {
        [Fact]
        public void Test_UpwardTrend()
        {
            var priceRange1 = new PriceRange
            {
                Open = 6,
                Close = 13
            };

            var priceRange2 = new PriceRange
            {
                Open = 13,
                Close = 6
            };

            Assert.True(priceRange1.UpwardTrend());
            Assert.False(priceRange2.UpwardTrend());
        }

        [Fact]
        public void Test_DownwardTrend()
        {
            var priceRange1 = new PriceRange
            {
                Open = 6,
                Close = 13
            };

            var priceRange2 = new PriceRange
            {
                Open = 13,
                Close = 6
            };

            Assert.False(priceRange1.DownwardTrend());
            Assert.True(priceRange2.DownwardTrend());
        }

        [Fact]
        public void Test_UpperShadow()
        {
            var priceRange1 = new PriceRange
            {
                Open = 6,
                Close = 6,
                High = 8
            };

            var priceRange2 = new PriceRange
            {
                Open = 6,
                Close = 8,
                High = 7
            };

            var priceRange3 = new PriceRange
            {
                Open = 8,
                Close = 6,
                High = 7
            };

            Assert.True(priceRange1.UpperShadow());
            Assert.False(priceRange2.UpperShadow());
            Assert.False(priceRange3.UpperShadow());
        }

        [Fact]
        public void Test_LowerShadow()
        {
            var priceRange1 = new PriceRange
            {
                Open = 6,
                Close = 6,
                Low = 5
            };

            var priceRange2 = new PriceRange
            {
                Open = 6,
                Close = 8,
                Low = 7
            };

            var priceRange3 = new PriceRange
            {
                Open = 8,
                Close = 6,
                Low = 7
            };

            Assert.True(priceRange1.LowerShadow());
            Assert.False(priceRange2.LowerShadow());
            Assert.False(priceRange3.LowerShadow());
        }

        [Fact]
        public void Test_DiffToUpperShadow()
        {
            var priceRange1 = new PriceRange
            {
                High = 3,
                Open = 1,
                Close = 2
            };

            var priceRange2 = new PriceRange
            {
                High = 3,
                Open = 2,
                Close = 1
            };

            var priceRange3 = new PriceRange
            {
                High = 2,
                Open = 1,
                Close = 2
            };

            var priceRange4 = new PriceRange
            {
                High = 2,
                Open = 2,
                Close = 1
            };

            Assert.Equal(1, priceRange1.DiffToUpperShadow());
            Assert.Equal(1, priceRange2.DiffToUpperShadow());
            Assert.Equal(0, priceRange3.DiffToUpperShadow());
            Assert.Equal(0, priceRange4.DiffToUpperShadow());
        }

        [Fact]
        public void Test_DiffToLowerShadow()
        {
            var priceRange1 = new PriceRange
            {
                Low = 0,
                Open = 1,
                Close = 2
            };

            var priceRange2 = new PriceRange
            {
                Low = 0,
                Open = 2,
                Close = 1
            };

            var priceRange3 = new PriceRange
            {
                Low = 1,
                Open = 1,
                Close = 2
            };

            var priceRange4 = new PriceRange
            {
                Low = 1,
                Open = 2,
                Close = 1
            };

            Assert.Equal(1, priceRange1.DiffToLowerShadow());
            Assert.Equal(1, priceRange2.DiffToLowerShadow());
            Assert.Equal(0, priceRange3.DiffToLowerShadow());
            Assert.Equal(0, priceRange4.DiffToLowerShadow());
        }
    }
}
