using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class HangingManStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Downtrend;

        protected override int _MaxNumberOfCandleSticks => 3;

        public HangingManStrategy()
        {
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

        public override bool StrategyMatch() => true;
    }
}
