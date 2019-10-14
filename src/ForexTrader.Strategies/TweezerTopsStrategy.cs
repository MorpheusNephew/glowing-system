using ForexTrader.Models;

namespace ForexTrader.Strategies
{
    public class TweezerTopsStrategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => Trend.Downtrend;

        protected override int _MaxNumberOfCandleSticks => 4;

        public override bool StrategyMatch() => true;
    }
}
