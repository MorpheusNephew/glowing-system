using ForexTrader.Models.Extensions;
using Xunit;

namespace ForexTrader.Models.Tests.Extensions
{
    public class PriceRangeExtensionsTests
    {
        [Fact]
        public void Test_ToCandleStick()
        {
            var priceRange = new PriceRange
            {
                Low = 1,
                High = 2,
                Open = 2,
                Close = 1
            };

            var candleStick = priceRange.ToCandleStick();

            Assert.Equal(priceRange, candleStick.PriceRange);
            Assert.Equal(Trend.Downtrend, candleStick.Trend);

            priceRange.Close = 3;

            candleStick = priceRange.ToCandleStick();

            Assert.Equal(Trend.Uptrend, candleStick.Trend);
        }
    }
}
