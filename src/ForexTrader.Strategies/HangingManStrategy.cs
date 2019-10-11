using System;
using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class HangingManStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Downtrend;

        protected override int _MaxNumberOfCandleSticks => throw new NotImplementedException();

        protected override Type _StrategyType => throw new NotImplementedException();

        public HangingManStrategy()
        {
            _CandleSticks = new List<CandleStick>();
            _InternalPattern = new List<CandleStick>
                {
                    new CandleStick
                    {
                        Shape = CandleStickShape.LongBodyLongerUpperShadow,
                        Trend = Trend.Uptrend
                    },
                    new CandleStick
                    {
                        Shape = CandleStickShape.ShortBodyLongLowerShadow,
                        Trend = Trend.Downtrend
                    },
                    new CandleStick
                    {
                        Shape = CandleStickShape.LongBodyLongerLowerShadow,
                        Trend = Trend.Downtrend
                    }
                };
        }

        protected override bool InternalStrategyMatch(int candleStickIndex) => true;
    }
}
