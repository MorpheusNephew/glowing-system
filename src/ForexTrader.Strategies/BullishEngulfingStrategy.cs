using System;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class BullishEngulfingStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Uptrend;

        protected override void EnsureCanAddCandleStick()
        {
            throw new NotImplementedException();
        }

        protected override bool InternalStrategyMatch(int candleStickIndex) => true;
    }
}
