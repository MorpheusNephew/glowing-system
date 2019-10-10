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
        public void Test_TopShadow()
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

            Assert.True(priceRange1.TopShadow());
            Assert.False(priceRange2.TopShadow());
            Assert.False(priceRange3.TopShadow());
        }

        [Fact]
        public void Test_BottomShadow()
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

            Assert.True(priceRange1.BottomShadow());
            Assert.False(priceRange2.BottomShadow());
            Assert.False(priceRange3.BottomShadow());
        }
    }
}
