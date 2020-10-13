using SplitArray.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitArray
{
    public static partial class ArraySplit
    {
        static readonly Lazy<Split> split_lazy = new Lazy<Split>();
        static readonly Lazy<Multiplication> multiplication_lazy = new Lazy<Multiplication>();
        static readonly Lazy<Subtract> subtract = new Lazy<Subtract>();
        static readonly Lazy<Addition> addition = new Lazy<Addition>();
        public static IEnumerable<IGrouping<int, T>> SplitLazy<T>(this IEnumerable<T> enumerable, int count_split)
        {
            return split_lazy.Value.Start(enumerable, count_split);
        }
        public static IEnumerable<IEnumerable<T>> MultiplicationLazy<T>(this IEnumerable<T> enumerable, int count_multiplication) where T : ICloneable
        {
            return multiplication_lazy.Value.Start(enumerable, count_multiplication);
        }
        public static IEnumerable<T> SubtractLazy<T>(this IEnumerable<T> enumerable, int count_subtract)
        {
            return subtract.Value.Start(enumerable, count_subtract);
        }
        public static IEnumerable<T> AdditionLazy<T>(this IEnumerable<T> enumerable, int count) where T : ICloneable
        {
            return addition.Value.Start(enumerable, count);
        }
    }
}
