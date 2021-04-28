
using System;
using IntervalMerge.Models;

namespace IntervalMerge.Services {

  public class IntervalService {

    public IInterval[] sortIntervals(IInterval[] values) {
      // EntryGuard: values must have at least one element
      if (values.Length < 1) {
        return new IInterval[0];
      }
      // Perform Sorting
      Array.Sort(values, new IntervalComparer());
      return values;
    }

    public int[] mergeIntervals(IInterval[] values) {
      // nyi !!!
        return new int[0];
    }
  }
}
