
using System.Collections;

namespace IntervalMerge.Models {

  public interface IInterval {
    int Lower { get; }
    int Upper { get; }
  }
  public class Interval: IInterval {

    private int _lower;
    public int Lower { get { return _lower; } }

    private int _upper;
    public int Upper { get { return _upper; } }

    public Interval(int lower, int upper) {
      _lower = lower;
      _upper = upper;
    }
  }

}
