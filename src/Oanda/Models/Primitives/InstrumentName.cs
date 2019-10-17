namespace Oanda.Models.Primitives
{
    public class InstrumentName
    {
        public string BaseCurrency;

        public string QuoteCurrency;

        public InstrumentName(string instrumentName)
        {
            var currencies = instrumentName.Split("_");

            BaseCurrency = currencies[0];
            QuoteCurrency = currencies[1];
        }

        public override string ToString() => $"{BaseCurrency}_{QuoteCurrency}";
    }
}