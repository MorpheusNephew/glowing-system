using System;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class TweezerBottomsStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => throw new NotImplementedException();

        protected override void EnsureCanAddCandleStick()
        {
            throw new NotImplementedException();
        }

        protected override bool InternalStrategyMatch(int candleStickIndex) => true;
    }
}
