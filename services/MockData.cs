
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
  }
}
