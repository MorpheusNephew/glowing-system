using System;

namespace ForexTrader.Models.Extensions
{
    public static class CandleStickShapeExtensions
    {
        public static string ToString(this CandleStickShape value) => Enum.GetName(typeof(CandleStickShape), value);
    }
}
