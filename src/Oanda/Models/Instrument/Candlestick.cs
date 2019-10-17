using System;

namespace Oanda.Models.Instrument
{
    public class Candlestick
    {
        public DateTime Time;

        public CandlestickData Bid;

        public CandlestickData Ask;

        public CandlestickData Mid;

        public int Volume;

        public bool Complete;
    }
}
