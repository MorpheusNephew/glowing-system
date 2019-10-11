using System;
using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public abstract class IStrategy
    {
        public abstract Trend ExpectedFutureTrend { get; }

        protected IList<CandleStick> _CandleSticks;

        protected IList<CandleStick> _InternalPattern;

        public bool StrategyMatch()
        {
            var lengthOfCandleSticks = NumOfCandleSticks();

            for (var i = 0; i < lengthOfCandleSticks; i++)
            {
                if (_CandleSticks[i].Shape != _InternalPattern[i].Shape
                    || _CandleSticks[i].Trend != _InternalPattern[i].Trend
                    || !InternalStrategyMatch(lengthOfCandleSticks))
                {
                    return false;
                }
            }

            return true;
        }

        public void AppendCandleStick(CandleStick candleStick)
        {
            if (_CandleSticks.Count >= 3)
            {
                throw new OverflowException("Max number of candle sticks is 3");
            }

            _CandleSticks.Add(candleStick);
        }

        public int NumOfCandleSticks()
        {
            return _CandleSticks.Count;
        }

        protected abstract bool InternalStrategyMatch(int candleStickIndex);
    }
}
