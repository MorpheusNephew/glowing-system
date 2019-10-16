using System;

namespace ForexTrader.Models.Extensions
{
    public static class StringExtensions
    {
        public static Trend ToTrend(this string value) => (Trend)Enum.Parse(typeof(Trend), value);

        public static CandleStickShape ToCandleStickShape(this string value) => (CandleStickShape)Enum.Parse(typeof(CandleStickShape), value);
    }
}
