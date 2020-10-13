using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitArray.Work
{
    class Subtract 
    {
        public IEnumerable<T> StartThread<T>(IEnumerable<T> list, int count_subtract)
        {
            return Start(list, count_subtract).ToList();
        }
        public IEnumerable<T> Start<T>(IEnumerable<T> list, int count_subtract)
        {
            lock (obj)
            {
                return list.Skip(count_subtract);
            }
        }
        object obj;
        public Subtract()
        {
            this.obj = new object();
        }
    }
}
