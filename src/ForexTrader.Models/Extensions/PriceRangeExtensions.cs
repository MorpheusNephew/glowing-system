using ForexTrader.Models.Factories;

namespace ForexTrader.Models.Extensions
{
    public static class PriceRangeExtensions
    {
        public static CandleStick ToCandleStick(this PriceRange priceRange) => new CandleStick
        {
            PriceRange = priceRange,
            Trend = priceRange.UpwardTrend ? Trend.Uptrend : Trend.Downtrend,
            Shape = CandleStickShapeFactory.GetCandleStickShape(priceRange)
        };
    }
}
