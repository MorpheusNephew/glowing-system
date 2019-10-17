using System.Collections.Generic;

namespace Oanda.Models.Position
{
    public class PositionSide
    {
        public decimal Units;

        public decimal AveragePrice;

        public IList<int> TradeIds;

        public decimal Pl;

        public decimal UnrealizedPl;

        public decimal ResettablePl;

        public decimal Financing;

        public decimal GuaranteedExecutionFees;
    }
}
