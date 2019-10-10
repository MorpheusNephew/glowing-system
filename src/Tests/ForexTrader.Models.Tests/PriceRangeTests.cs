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
    }
}
