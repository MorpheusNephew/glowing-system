namespace ForexTrader.Models
{
    public enum CandleStickShape
    {
        LongBodyLongLowerShadow,
        LongBodyLongerLowerShadow, // Longer than the upper shadow
        LongBodyLongerUpperShadow, // Longer than the lower shadow
        LongBodyLongShadows,
        LongBodyLongUpperShadow,
        LongBodyNoShadows,

        ShortBodyLongLowerShadow,
        ShortBodyLongerLowerShadow, // Longer than the upper shadow
        ShortBodyLongerUpperShadow, // Longer than the lower shadow
        ShortBodyLongShadows,
        ShortBodyLongUpperShadow,
        ShortBodyNoShadows,

        TinyBodyLongLowerShadow,
        TinyBodyLongerLowerShadow, // Longer than the upper shadow
        TinyBodyLongerUpperShadow, // Longer than the lower shadow
        TinyBodyLongShadows,
        TinyBodyLongUpperShadow,
        TinyBodyNoShadows
    }
}
