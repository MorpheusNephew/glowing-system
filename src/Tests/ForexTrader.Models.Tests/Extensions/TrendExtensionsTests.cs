using Xunit;

namespace ForexTrader.Models.Tests.Extensions
{
    public class TrendExtensionsTests
    {
        [Fact]
        public void Test_ToString()
        {
            var uptrend = Trend.Uptrend.ToString();
            var downtrend = Trend.Downtrend.ToString();

            Assert.Equal("Uptrend", uptrend);
            Assert.Equal("Downtrend", downtrend);
        }
    }
}
