using System.Collections.Generic;

namespace ForexTrader.Strategies.Managers
{
    public class StrategyManager : IStrategyManager
    {
        public IList<IStrategy> GetStrategies() => new List<IStrategy>
            {
                new HammerStrategy(),
                new HangingManStrategy(),
                new InvertedHammerStrategy(),
                new ShootingStartStrategy()
            };
    }
}
