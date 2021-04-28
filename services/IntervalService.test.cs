// /Program.test.cs
using System;
using System.Collections.Generic;
using System.Linq;
using IntervalMerge.Models;
using Xunit;

namespace IntervalMerge.Services.Test
{
    // nyi !!!
    public class IntervalServiceTest
    {
        public static bool checkEquality<T>(T[] first, T[] second) {
            return first.SequenceEqual(second);
        }

        [Fact]
        public void TestSortIntervalsShouldSortByLowerBoundValue() {
            var sut = new IntervalService();
            var actual = sut.sortIntervals(MockData.exampleInput);
            var expected = MockData.exampleSortedExpected;
            Assert.True(checkEquality(expected, actual));
        }

        [Fact]
        public void TestMergeIntervalsShouldReturnCorrectMergedIntervals() {
            var sut = new IntervalService();
            var actual = sut.mergeIntervals(MockData.exampleInput);
            var expected = MockData.exampleExpected;
            Assert.True(expected.Equals(actual));
        }
    }
}
