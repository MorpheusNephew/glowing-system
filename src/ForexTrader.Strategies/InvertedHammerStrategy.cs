using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class InvertedHammerStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Uptrend;

        protected override int _MaxNumberOfCandleSticks => 3;

        public InvertedHammerStrategy()
        {
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

        public override bool StrategyMatch() => true;
    }
}
