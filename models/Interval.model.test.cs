// /Program.test.cs
using Xunit;

namespace IntervalMerge.Models.Test {
    // nyi !!!
    public class TestInterval {

        [Theory]
        [InlineData(25,30)]
        [InlineData(2,19)]
        [InlineData(14,23)]
        [InlineData(4,8)]
        public void TestIntervalModel(int lowerValue, int upperValue) {
            var sut = new Interval(lowerValue, upperValue);
            Assert.Equal(lowerValue, sut.LowerValue);
            Assert.Equal(upperValue, sut.UpperValue);
        }
    }
}
