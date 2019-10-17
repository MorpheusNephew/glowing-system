using System;
using Oanda.Models.Transaction;

namespace Oanda.Models.Order
{
    public class Order
    {
        public int Id;

        public DateTime CreateTime;

        public OrderState State;

        public ClientExtensions ClientExtensions;
    }
}
