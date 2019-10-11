namespace ForexTrader.Strategies
{
    public class InvertedHammerStrategy : IStrategy
    {
        protected override bool InternalStrategyMatch(int candleStickIndex)
        {
            return true;
        }
    }
}
