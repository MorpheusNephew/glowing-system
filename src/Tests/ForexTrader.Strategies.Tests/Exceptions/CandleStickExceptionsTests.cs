using System;
using ForexTrader.Strategies.Exceptions;
using Xunit;

namespace ForexTrader.Strategies.Tests.Exceptions
{
    public class CandleStickExceptionsTests
    {
        [Fact]
        public void Test_MaxNumberOfCandleSticks()
        {
            const int maxNumberOfCandleSticks = 3;
            var strategyType = typeof(IStrategy);

            var exception = CandleStickExceptions.MaxNumberOfCandleSticks(strategyType, maxNumberOfCandleSticks);

            Assert.Equal($"Max number of candle sticks for {strategyType} is {maxNumberOfCandleSticks}", exception.Message);
            Assert.Equal(typeof(OverflowException), exception.GetType());
        }
    }
}
