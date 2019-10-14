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

        protected IStrategy()
        {
            _CandleSticks = new List<CandleStick>();
        }

        public void AppendCandleStick(CandleStick candleStick)
        {
            if (NumOfCandleSticks() >= _MaxNumberOfCandleSticks)
            {
                throw CandleStickExceptions.MaxNumberOfCandleSticks(this.GetType(), _MaxNumberOfCandleSticks);
            }

            _CandleSticks.Add(candleStick);
        }

        public int NumOfCandleSticks() => _CandleSticks.Count;

        public bool HasMaxCandleSticks() => NumOfCandleSticks() >= _MaxNumberOfCandleSticks;

        public abstract bool StrategyMatch();
    }
}
