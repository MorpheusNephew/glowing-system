using System;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class BearishEngulfingStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Downtrend;

        protected override void EnsureCanAddCandleStick()
        {
            throw new NotImplementedException();
        }

        protected override bool InternalStrategyMatch(int candleStickIndex) => true;
    }
}
