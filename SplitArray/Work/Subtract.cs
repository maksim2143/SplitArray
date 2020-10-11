using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitArray.Work
{
    class Subtract
    {
        public IEnumerable<T> Start<T>(IEnumerable<T> list, int count_subtract)
        {
            return list.Skip(count_subtract).ToList();
        }
    }
}
