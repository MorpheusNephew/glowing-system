using System.Collections.Generic;

namespace ForexTrader.Strategies.Managers
{
    public interface IStrategyManager
    {
        public IList<IStrategy> GetStrategies();
    }
}
