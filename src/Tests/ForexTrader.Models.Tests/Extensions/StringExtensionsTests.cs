using Xunit;
using ForexTrader.Models.Extensions;
using ForexTrader.Models.Tests.TestData;

namespace ForexTrader.Models.Tests.Extensions
{
    public class StringExtensionsTests
    {
        [Theory]
        [ClassData(typeof(CandleStickShapeTestData))]
        public void Test_ToCandleStickShape(string candleStickShape, CandleStickShape expectedCandleStickShape) => Assert.Equal(expectedCandleStickShape, candleStickShape.ToCandleStickShape());

        [Theory]
        [InlineData("Uptrend", Trend.Uptrend)]
        [InlineData("Downtrend", Trend.Downtrend)]
        public void Test_ToTrend(string trend, Trend expectedTrend) => Assert.Equal(expectedTrend, trend.ToTrend());
    }
}
