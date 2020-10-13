using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitArray.Work
{
    class Multiplication
    {
        public IEnumerable<IEnumerable<T>> Start<T>(IEnumerable<T> enumerable, int count_multiplication) where T : ICloneable
        {
            lock (obj)
            {
                return enumerable.Select(x =>
                {
                    List<T> list = new List<T>() { x };
                    for (int i = 1; i < count_multiplication; i++)
                    {
                        list.Add((T)x.Clone());
                    }
                    return list;
                });
            }
        }
        public IEnumerable<IEnumerable<T>> StartThread<T>(IEnumerable<T> enumerable, int count_multiplication) where T : ICloneable
        {
            return this.Start(enumerable, count_multiplication).ToList();
        }
        object obj;
        public Multiplication()
        {
            this.obj = new object();
        }
    }
}
