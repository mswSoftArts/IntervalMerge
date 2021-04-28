
using System.Collections;

namespace IntervalMerge.Models {

  public class IntervalComparer : IComparer {
    int IComparer.Compare(object x, object y) {
      // Casting to target type
      IInterval cur = (IInterval)x;
      IInterval succ = (IInterval)y;

      if (cur.Lower == succ.Lower) {
        return cur.Upper - succ.Upper;
      }
      return cur.Lower - succ.Upper;
    }
  }
}
