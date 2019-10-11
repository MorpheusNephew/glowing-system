using System;
using System.Collections.Generic;
using ForexTrader.Models;
using ForexTrader.Strategies.Exceptions;

namespace ForexTrader.Strategies
{
    public abstract class IStrategy
    {
        public abstract Trend ExpectedFutureTrend { get; }

        protected IList<CandleStick> _CandleSticks;

        protected IList<CandleStick> _InternalPattern;

        protected abstract int _MaxNumberOfCandleSticks { get; }

        protected abstract Type _StrategyType { get; }

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
            if (NumOfCandleSticks() >= _MaxNumberOfCandleSticks)
            {
                throw CandleStickExceptions.MaxNumberOfCandleSticks(_StrategyType, _MaxNumberOfCandleSticks);
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
