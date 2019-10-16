using System.Collections.Generic;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class BullishEngulfingStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Uptrend;

        protected override int _MaxNumberOfCandleSticks => 4;

        public BullishEngulfingStrategy()
        {
            _InternalPattern = new List<CandleStick>
            {
                new CandleStick
                {
                    Trend = Trend.Downtrend,
                },
                new CandleStick
                {
                    Trend = Trend.Downtrend,
                    Shape = CandleStickShape.ShortBodyLongerLowerShadow
                },
                new CandleStick
                {
                    Trend = Trend.Uptrend,
                    Shape = CandleStickShape.LongBodyLongerUpperShadow
                },
                new CandleStick
                {
                    Trend = Trend.Uptrend
                }
            };
        }

        public override bool StrategyMatch() => true;
    }
}
