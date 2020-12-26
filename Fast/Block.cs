using System;
using System.Collections.Generic;
using System.Text;

namespace Fast
{
    class Block<T>
    {
        public T Current
        {
            get
            {
                lock (this.block)
                {
                    return current;
                }
            }
            set
            {
                lock (this.block)
                {
                    current = value;
                }
            }
        }
        private T current;
        object block;
        public Block()
        {

            this.block = new object();
        }
    }
}
