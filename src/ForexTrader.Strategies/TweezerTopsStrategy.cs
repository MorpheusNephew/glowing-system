using System;
using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class TweezerTopsStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => throw new NotImplementedException();

        protected override int _MaxNumberOfCandleSticks => throw new NotImplementedException();

        protected override Type _StrategyType => throw new NotImplementedException();

        protected override bool InternalStrategyMatch(int candleStickIndex) => true;
    }
}
