
using System;
using System.Collections;
using System.Collections.Generic;
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

    public IInterval[] mergeIntervals(IInterval[] values) {
      var sortedValues = this.sortIntervals(values);

      // Initialize Stack of intervals
      var intervals = new Stack<IInterval>();

      // Push first interval to stack
      intervals.Push(sortedValues[0]);
      for (var i = 0; i < sortedValues.Length; i++) {
        // get top interval from stack
        var top = intervals.Peek();

        // if cur interval is not overlapping with top
        // push it to stack
        if (top.UpperValue < sortedValues[i].LowerValue) {
          intervals.Push(sortedValues[i]);
        } else if (top.UpperValue < sortedValues[i].UpperValue) {
            intervals.Pop();
            intervals.Push(new Interval(
              top.LowerValue,
              sortedValues[i].UpperValue
            ));
        }
      }
      return intervals.ToArray();
    }
  }
}
