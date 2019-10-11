namespace ForexTrader.Strategies
{
    public class ShootingStartStrategy : IStrategy
    {
        protected override bool InternalStrategyMatch(int candleStickIndex)
        {
            return true;
        }
    }
}
