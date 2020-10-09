using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitArray
{
    enum Check
    {
        Division,Multiplication,Addition,Subtraction
    }
    class Array
    {
        public void Split<T>(IEnumerable<T> enumerable, Check check,int count)
        {

        }
    }
    class Sp {

        public Sp()
        {
            new Array().Split(Enumerable.Range(0, 1000), Check.Subtraction, 54);
        }
    }

}
