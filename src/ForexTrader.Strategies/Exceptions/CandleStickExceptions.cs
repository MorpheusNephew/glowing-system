using System;

namespace ForexTrader.Strategies.Exceptions
{
    public static class CandleStickExceptions
    {
        public static Exception MaxNumberOfCandleSticks(Type strategyType, int numberOfCandleSticks) => new OverflowException($"Max number of candle sticks for {strategyType} is {numberOfCandleSticks}");
    }
}
