using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class InvertedHammerStrategy : IStrategy
    {
        public InvertedHammerStrategy()
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
                        Shape = CandleStickShape.ShortBodyLongUpperShadow,
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
