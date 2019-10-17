using System;
using System.Collections.Generic;
using Oanda.Models.Trade;

namespace Oanda.Models.Account
{
    public class Account
    {
        public AccountId Id;

        public string Alias;

        public string Currency;

        public decimal Balance;

        public int CreatedByUserId;

        public DateTime CreatedTime;

        public GuaranteedStopLossOrderMode GuaranteedStopLossOrderMode;

        public decimal Pl;

        public decimal ResettablePl;

        public DateTime ResettablePlTime;

        public decimal Financing;

        public decimal Commission;

        public decimal GuranteedExecutionFees;

        public decimal MarginRate;

        public DateTime MarginCallEnterTime;

        public int MarginCallExtensionCount;

        public DateTime LastMarginCallExtensionTime;

        public int OpenTradeCount;

        public int OpenPositionCount;

        public int PendingOrderCount;

        public bool HedgingEnabled;

        public decimal UnrealizedPl;

        public decimal Nav;

        public decimal MarginUsed;

        public decimal MarginAvailable;

        public decimal PositionValue;

        public decimal MarginCloseoutUnrealizedPl;

        public decimal MarginCloseoutNav;

        public decimal MarginCloseoutPercent;

        public decimal MarginCloseoutPositionValue;

        public decimal WithdrawalLimit;

        public decimal MarginCallPercent;

        public int LastTransactionId;

        public IList<TradeSummary> Trades;

        public IList<Position.Position> Positions;

        public IList<Order.Order> Orders;
    }
}
