using System.Collections;
using System.Collections.Generic;

namespace ForexTrader.Models.Tests.TestData
{
    public class CandleStickShapeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "LongBodyLongLowerShadow", CandleStickShape.LongBodyLongLowerShadow };
            yield return new object[] { "LongBodyLongerLowerShadow", CandleStickShape.LongBodyLongerLowerShadow };
            yield return new object[] { "LongBodyLongerUpperShadow", CandleStickShape.LongBodyLongerUpperShadow };
            yield return new object[] { "LongBodyLongShadows", CandleStickShape.LongBodyLongShadows };
            yield return new object[] { "LongBodyLongUpperShadow", CandleStickShape.LongBodyLongUpperShadow };
            yield return new object[] { "LongBodyNoShadows", CandleStickShape.LongBodyNoShadows };
            yield return new object[] { "ShortBodyLongLowerShadow", CandleStickShape.ShortBodyLongLowerShadow };
            yield return new object[] { "ShortBodyLongerLowerShadow", CandleStickShape.ShortBodyLongerLowerShadow };
            yield return new object[] { "ShortBodyLongerUpperShadow", CandleStickShape.ShortBodyLongerUpperShadow };
            yield return new object[] { "ShortBodyLongShadows", CandleStickShape.ShortBodyLongShadows };
            yield return new object[] { "ShortBodyLongUpperShadow", CandleStickShape.ShortBodyLongUpperShadow };
            yield return new object[] { "ShortBodyNoShadows", CandleStickShape.ShortBodyNoShadows };
            yield return new object[] { "TinyBodyLongLowerShadow", CandleStickShape.TinyBodyLongLowerShadow };
            yield return new object[] { "TinyBodyLongerLowerShadow", CandleStickShape.TinyBodyLongerLowerShadow };
            yield return new object[] { "TinyBodyLongerUpperShadow", CandleStickShape.TinyBodyLongerUpperShadow };
            yield return new object[] { "TinyBodyLongShadows", CandleStickShape.TinyBodyLongShadows };
            yield return new object[] { "TinyBodyLongUpperShadow", CandleStickShape.TinyBodyLongUpperShadow };
            yield return new object[] { "TinyBodyNoShadows", CandleStickShape.TinyBodyNoShadows };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
