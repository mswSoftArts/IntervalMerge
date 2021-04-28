// /Program.test.cs
using System;
using System.Collections.Generic;
using IntervalMerge.Models;
using Xunit;

namespace IntervalMerge.Services.Test
{
    // nyi !!!
    public class TestIntervalService
    {
        [Fact]
        public void TestMergeIntervalsShouldReturnCorrectMergedIntervals() {
            var sut = new IntervalService();
            var actual = sut.mergeIntervals(MockData.exampleInput);
            var expected = MockData.exampleExpected;
            Assert.True(expected.Equals(actual));
        }
    }
}
