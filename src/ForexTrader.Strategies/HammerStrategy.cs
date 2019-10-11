using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class HammerStrategy : IStrategy
    {
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

        public override Trend ExpectedFutureTrend()
        {
            return Trend.Uptrend;
        }

        protected override bool InternalStrategyMatch(int candleStickIndex)
        {
            return true;
        }
    }
}
