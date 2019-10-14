using System;

namespace ForexTrader.Models.Extensions
{
    public static class TrendExtensions
    {
        public static string ToString(this Trend value) => Enum.GetName(typeof(Trend), value);
    }
}
