using System;
using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public abstract class IStrategy
    {
        protected IList<CandleStick> _CandleSticks;

        protected IList<CandleStick> _InternalPattern;

        public bool StrategyMatch()
        {
            var lengthOfCandleSticks = _CandleSticks.Count;

            for (var i = 0; i < lengthOfCandleSticks; i++)
            {
                if (_CandleSticks[i].Shape != _InternalPattern[i].Shape)
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


    }
}
