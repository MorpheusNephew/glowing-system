using System;
using System.Collections.Generic;
using Oanda.Models.Primitives;

namespace Oanda.Models.Instrument
{
    public class PositionBook
    {
        public InstrumentName Instrument;

        public DateTime Time;

        public decimal Price;

        public decimal BucketWidth;

        public IList<PositionBookBucket> Buckets;
    }
}
