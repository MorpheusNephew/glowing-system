namespace ForexTrader.Strategies
{
    public class HangingManStrategy : IStrategy
    {
        protected override bool InternalStrategyMatch(int candleStickIndex)
        {
            return true;
        }
    }
}
