using System;

namespace ForexTrader.Models
{
    public class PriceRange
    {
        public double High;

        public double Low;

        public double Open;

        public double Close;

        public bool UpwardTrend()
        {
            return Close > Open;
        }

        public bool DownwardTrend()
        {
            return Open > Close;
        }

        public bool UpperShadow()
        {
            return High > Open && High > Close;
        }

        public double DiffToUpperShadow()
        {
            var highestValue = Math.Max(Open, Close);

            return High - highestValue;
        }

        public bool LowerShadow()
        {
            return Low < Open && Low < Close;
        }

        public double DiffToLowerShadow()
        {
            var lowestValue = Math.Min(Open, Close);

            return lowestValue - Low;
        }
    }
}
