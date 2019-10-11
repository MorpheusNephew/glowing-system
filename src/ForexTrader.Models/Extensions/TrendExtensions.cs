using System;

namespace ForexTrader.Models.Extensions
{
    public static class TrendExtensions
    {
        public static string ToString(this Trend trend) => Enum.GetName(typeof(Trend), trend);
    }
}
