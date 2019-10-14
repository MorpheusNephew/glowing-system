using System;

namespace ForexTrader.Models
{
    public class PriceRange
    {
        public double Close;

        public double High;

        public double Low;

        public double Open;

        public bool DownwardTrend => Open > Close;

        public double DiffToLowerShadow
        {
            get
            {
                var lowestValue = Math.Min(Open, Close);

                return lowestValue - Low;
            }
        }

        public double DiffToUpperShadow
        {
            get
            {
                var highestValue = Math.Max(Open, Close);

                return High - highestValue;
            }
        }

        public bool LowerShadow => Low < Open && Low < Close;

        public double OpenCloseDiff => Math.Abs(Open - Close);

        public bool UpperShadow => High > Open && High > Close;

        public bool UpwardTrend => Close > Open;
    }
}
