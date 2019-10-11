using System;
using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class HammerStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Uptrend;

        protected override int _MaxNumberOfCandleSticks => 3;

        protected override Type _StrategyType => typeof(HammerStrategy);

        public HammerStrategy()
        {
            _CandleSticks = new List<CandleStick>();
            _InternalPattern = new List<CandleStick>
                {
                    new CandleStick
                    {
                        Shape = CandleStickShape.LongBodyLongerLowerShadow,
                        Trend = Trend.Downtrend
                    },
                    new CandleStick
                    {
                        Shape = CandleStickShape.ShortBodyLongLowerShadow,
                        Trend = Trend.Uptrend
                    },
                    new CandleStick
                    {
                        Shape = CandleStickShape.LongBodyLongerUpperShadow,
                        Trend = Trend.Uptrend
                    }
                };
        }

        protected override bool InternalStrategyMatch(int candleStickIndex) => true;
    }
}
