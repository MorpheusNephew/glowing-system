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

        public bool TopShadow()
        {
            return High > Open && High > Close;
        }

        public bool BottomShadow()
        {
            return Low < Open && Low < Close;
        }
    }
}
