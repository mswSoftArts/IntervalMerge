
using System;
using System.Diagnostics;

namespace IntervalMerge.Models {

  public interface IInterval: IEquatable<IInterval> {
    int LowerValue { get; }
    int UpperValue { get; }
  }

  [DebuggerDisplay("{DebuggerDisplay,nq}")]
  public sealed class Interval: IInterval, IEquatable<IInterval> {

    private int _lower;
    public int LowerValue { get { return _lower; } }

    private int _upper;
    public int UpperValue { get { return _upper; } }

    private string DebuggerDisplay {
      get {
        return $"[{_lower},{_upper}]";
      }
    }

    public override string ToString() {
        return $"[{_lower},{_upper}]";
    }

    public Interval(int lower, int upper) {
      _lower = lower;
      _upper = upper;
    }

    public override bool Equals(object other) {
      var _other = (IInterval)other;
      var result =  this._lower == _other.LowerValue && this._upper == _other.UpperValue;
      Debug.WriteLine($"Equals o: {result}");
      return result;
    }

    public bool Equals(IInterval other) {
      var _other = (IInterval)other;
      var result =  this._lower == _other.LowerValue && this._upper == _other.UpperValue;
      Debug.WriteLine($"Equals: {result}");
      return result;
    }

    public override int GetHashCode()
    {
      unchecked {
        return (this._lower * 397) ^ this._upper;
      }
    }
  }

}
