using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class TweezerBottomsStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Uptrend;

        protected override int _MaxNumberOfCandleSticks => 4;

        public override bool StrategyMatch() => true;
    }
}
