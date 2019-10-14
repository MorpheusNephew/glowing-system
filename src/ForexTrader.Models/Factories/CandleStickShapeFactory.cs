using System;
using ForexTrader.Models.Extensions;

namespace ForexTrader.Models.Factories
{
    public static class CandleStickShapeFactory
    {
        private static double _LargeBody;

        private static double _TinyBody;

        private static double _UpperLowerShadowDiff;

        static CandleStickShapeFactory()
        {
            /*
                This is where the configuration file that will determine
                things like long body vs tiny body and to what degree
                the difference between differential of long vs short
                shadows will determine to use longer shadow vs long shadow
                also the special case of if both shadows are somehow equally
                long then... Figure that part out.
             */

            _LargeBody = 0.0003; // change to a value coming from configuration settings
            _TinyBody = 0.0000003; // change to value coming from configuration settings
            _UpperLowerShadowDiff = 0.0003; // change to value coming from configuration settings
        }

        public static CandleStickShape GetCandleStickShape(PriceRange priceRange)
        {
            if (priceRange.OpenCloseDiff >= _LargeBody)
            {
                return GetLongBodyCandleStickShape(priceRange);
            }

            if (priceRange.OpenCloseDiff <= _TinyBody)
            {
                return GetTinyBodyCandleStickShape(priceRange);
            }

            return GetShortBodyCandleStickShape(priceRange);
        }

        private static CandleStickShape GetCandleStickShapeInternal(
            PriceRange priceRange,
            Func<string, CandleStickShape> getCandleStickShape)
        {
            if (priceRange.NoShadows)
            {
                return getCandleStickShape("NoShadows");
            }

            if (priceRange.DiffToLowerShadow >= _UpperLowerShadowDiff
                && priceRange.DiffToUpperShadow >= _UpperLowerShadowDiff)
            {
                return getCandleStickShape("LongShadows");
            }

            if (priceRange.LongerLowerShadow)
            {
                return priceRange.DiffToLowerShadow >= _UpperLowerShadowDiff
                    ? getCandleStickShape("LongLowerShadow")
                    : getCandleStickShape("LongerLowerShadow");
            }

            if (priceRange.LongerUpperShadow)
            {
                return priceRange.DiffToUpperShadow >= _UpperLowerShadowDiff
                    ? getCandleStickShape("LongUpperShadow")
                    : getCandleStickShape("LongerUpperShadow");
            }

            throw new OverflowException("Case has not been accounted for");
        }

        private static CandleStickShape GetLongBodyCandleStickShape(PriceRange priceRange) =>
            GetCandleStickShapeInternal(priceRange, StringToCandleStickShapeInternal("LongBody"));

        private static CandleStickShape GetShortBodyCandleStickShape(PriceRange priceRange) =>
            GetCandleStickShapeInternal(priceRange, StringToCandleStickShapeInternal("ShortBody"));

        private static CandleStickShape GetTinyBodyCandleStickShape(PriceRange priceRange) =>
            GetCandleStickShapeInternal(priceRange, StringToCandleStickShapeInternal("TinyBody"));

        private static Func<string, CandleStickShape> StringToCandleStickShapeInternal(string candleStickSize) =>
            (candleStickType) => $"{candleStickSize}{candleStickType}".ToCandleStickShape();
    }
}
