using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitArray.Work
{
   public class Split
    {
        public IEnumerable<IGrouping<int,T>> Start<T>(IEnumerable<T> enumerator,int count_split)
        {
            int count = 0;
            return enumerator.GroupBy(x =>
            {
                if (count_split < count) count = 0;
                count++;
                return count;
            }).ToList();
        }
    }
}
