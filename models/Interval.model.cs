
using System;

namespace IntervalMerge.Models {

  public interface IInterval: IEquatable<IInterval> {
    int LowerValue { get; }
    int UpperValue { get; }
  }

  public class Interval: IInterval {

    private int _lower;
    public int LowerValue { get { return _lower; } }

    private int _upper;
    public int UpperValue { get { return _upper; } }

    public Interval(int lower, int upper) {
      _lower = lower;
      _upper = upper;
    }

    public bool Equals(IInterval other) {
      return this._lower == other.LowerValue && this._upper == other.UpperValue;
    }

    public override int GetHashCode()
    {
      return this._lower * this._upper;
    }
  }

}
