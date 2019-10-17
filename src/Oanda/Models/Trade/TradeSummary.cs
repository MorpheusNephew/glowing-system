using System;
using System.Collections.Generic;
using Oanda.Models.Primitives;
using Oanda.Models.Transaction;

namespace Oanda.Models.Trade
{
    public class TradeSummary
    {
        public int Id;

        public InstrumentName Instrument;

        public decimal Price;

        public DateTime OpenTime;

        public TradeState State;

        public decimal InitialUnits;

        public decimal InitialMarginRequired;

        public decimal CurrentUnits;

        public decimal RealizedPl;

        public decimal UnrealizedPl;

        public decimal MarginUsed;

        public decimal AverageClosePrice;

        public IList<int> ClosingTransactionIds;

        public decimal Financing;

        public DateTime CloseTime;

        public ClientExtensions ClientExtensions;

        public int TakeProfitOrderId;

        public int StopLossOrderId;

        public int TrailingStopLossOrderId;
    }
}
