namespace Oanda.Models.Primitives
{
    public class Instrument
    {
        public InstrumentName Name;

        public InstrumentType Type;

        public string DisplayName;

        /*
            The location of the “pip” for this instrument. The decimal position of
            the pip in this Instrument’s price can be found at 10 ^ pipLocation (e.g.
            -4 pipLocation results in a decimal pip position of 10 ^ -4 = 0.0001).
         */
        public int PipLocation;

        /*
            The number of decimal places that should be used to display prices for
            this instrument. (e.g. a displayPrecision of 5 would result in a price of
            “1” being displayed as “1.00000”)
         */
        public int DisplayPrecision;

        /*
            The amount of decimal places that may be provided when specifying the
            number of units traded for this instrument.
         */
        public int TradeUnitsPrecision;

        public decimal MinimumTradeSize;

        public decimal MaximumTrailingStopDistance;

        public decimal MaximumPositionSize;

        public decimal MaximumOrderUnits;

        public decimal MarginRate;

        public InstrumentCommission Commission;
    }
}