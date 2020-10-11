using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitArray.Work
{
    class Addition
    {
        public IEnumerable<T> Start<T>(IEnumerable<T> enumerable,int count)where T : ICloneable
        {
            lock (obj)
            {
                if (!(enumerable.Count() > 0)) return enumerable;
                List<T> list = new List<T>();
                foreach (var item in enumerable)
                {
                    list.Add(item);
                    for (int i = 1; i < count; i++)
                    {
                        list.Add((T)item.Clone());
                    }
                }
                return list;
            }
        }
        object obj;
        public Addition()
        {
            this.obj = new object();
        }
    }
}
