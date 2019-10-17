using Oanda.Models.Primitives;

namespace Oanda.Models.Position
{
    public class Position
    {
        public InstrumentName Instrument;

        public decimal Pl;

        public decimal UnrealizedPl;

        public decimal MarginUsed;

        public decimal ResettablePl;

        public decimal Financing;

        public decimal Commission;

        public decimal GuaranteedExecutionFees;

        public PositionSide Long;

        public PositionSide Short;
    }
}
