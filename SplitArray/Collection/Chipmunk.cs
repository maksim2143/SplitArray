using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace SplitArray
{
    public class Chipmunk<T>
    {
        public int Count()
        {
            return  this.enumerable.Count();
        }
        public T Dequeue()
        {
            var value = enumerable.First();
            Remove(value);
            return default;
        }
        public void Remove(T t)
        {
            
        }
        IEnumerable<T> enumerable;
        public Chipmunk(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }
    }
}
