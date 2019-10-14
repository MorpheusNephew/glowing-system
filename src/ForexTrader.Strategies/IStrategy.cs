using System.Collections.Generic;
using ForexTrader.Models;
using ForexTrader.Strategies.Exceptions;

namespace ForexTrader.Strategies
{
    public abstract class IStrategy
    {
        public abstract Trend ExpectedFutureTrend { get; }

        protected abstract int _MaxNumberOfCandleSticks { get; }

        protected IList<CandleStick> _CandleSticks;

        protected IList<CandleStick> _InternalPattern;

        protected IStrategy()
        {
            _CandleSticks = new List<CandleStick>();
        }

        public void AppendCandleStick(CandleStick candleStick)
        {
            if (HasMaxCandleSticks())
            {
                throw CandleStickExceptions.MaxNumberOfCandleSticks(this.GetType(), _MaxNumberOfCandleSticks);
            }

            _CandleSticks.Add(candleStick);
        }

        public bool HasMaxCandleSticks() => _CandleSticks.Count >= _MaxNumberOfCandleSticks;

        public abstract bool StrategyMatch();
    }
}
