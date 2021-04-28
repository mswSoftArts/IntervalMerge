
using IntervalMerge.Models;

namespace IntervalMerge.Services.Test {
  public static class MockData {
    public static IInterval[] exampleInput = new IInterval[] {
      new Interval(25, 30),
      new Interval(2, 19),
      new Interval(14, 23),
      new Interval(4, 8),
    };
    public static IInterval[] exampleSortedExpected = new IInterval[] {
      new Interval(2, 19),
      new Interval(4, 8),
      new Interval(14, 23),
      new Interval(25, 30),
    };

    public static IInterval[] exampleExpected = new IInterval[] {
      new Interval(2, 23),
      new Interval(25, 30),
    };

    public static IInterval[] largeValuesInput = new IInterval[] {
      new Interval(2147483000, 2147483010),
      new Interval(2147483040, 2147483180),
      new Interval(2147483038, 2147483647),
    };

    public static IInterval[] largeValuesExpected = new IInterval[] {
      new Interval(2147483000, 2147483010),
      new Interval(2147483038, 2147483647),
    };

  }
}
