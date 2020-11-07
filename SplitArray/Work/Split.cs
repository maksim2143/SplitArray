using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace SplitArray.Work
{
   public class Split
    {
        public IEnumerable<IGrouping<int, T>> StartThread<T>(IEnumerable<T> enumerator, int count_split)
        {
            return this.Start(enumerator, count_split).ToList();
        }
        public IEnumerable<IGrouping<int, T>> Start<T>(IEnumerable<T> enumerator,int count_split)
        {
            lock (obj)
            {
                count_split--;
                int count = 0;
                return enumerator.GroupBy(x =>
                {
                    if (count_split < count) count = 0;
                    count++;
                    return count;
                });
            }
        }

        object obj;
        public Split()
        {
            this.obj = new object();
        }
    }
}
