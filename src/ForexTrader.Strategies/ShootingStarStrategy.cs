using System;
using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class ShootingStarStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Downtrend;

        protected override int _MaxNumberOfCandleSticks => 3;

        protected override Type _StrategyType => typeof(ShootingStarStrategy);

        public ShootingStarStrategy()
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
                        Shape = CandleStickShape.ShortBodyLongUpperShadow,
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
