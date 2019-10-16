using System;
using ForexTrader.Models;
using Xunit;

namespace ForexTrader.Strategies.Tests
{
    public class IStrategyTests
    {
        [Fact]
        public void Test_MaxNumberOfCandleSticks()
        {
            var strategy = new Strategy();

            Assert.False(strategy.HasMaxCandleSticks());

            strategy.AppendCandleStick(new CandleStick());

            Assert.False(strategy.HasMaxCandleSticks());

            strategy.AppendCandleStick(new CandleStick());

            Assert.False(strategy.HasMaxCandleSticks());

            strategy.AppendCandleStick(new CandleStick());

            Assert.True(strategy.HasMaxCandleSticks());

            Assert.Throws(typeof(OverflowException), () => strategy.AppendCandleStick(new CandleStick()));
        }
    }

    public class Strategy : IStrategy
    {
        public override Trend ExpectedFutureTrend => throw new NotImplementedException();

        protected override int _MaxNumberOfCandleSticks => 3;

        public override bool StrategyMatch() => throw new NotImplementedException();
    }
}
