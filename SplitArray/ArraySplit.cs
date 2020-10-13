using SplitArray.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitArray
{
    public  static partial class ArraySplit
    {
        #region Lazy

        #endregion
        #region Thread
        public static IEnumerable<IGrouping<int, T>> Split<T>(this IEnumerable<T> enumerable,int count_split)
        {
            return new Split().StartThread(enumerable, count_split);
        }
        public static IEnumerable<IEnumerable<T>> Multiplication<T>(this IEnumerable<T> enumerable, int count_multiplication) where T: ICloneable
        {
            return new Multiplication().StartThread(enumerable, count_multiplication);
        }
        public static IEnumerable<T> Subtract<T>(this IEnumerable<T> enumerable, int count_subtract)
        {
             return new Subtract().StartThread(enumerable, count_subtract);
        }
        public static IEnumerable<T> Addition<T>(this IEnumerable<T> enumerable,int count) where T:ICloneable
        {
            return new Addition().Start(enumerable, count);
        }
        #endregion
    }
}
