using System;
using System.Collections.Generic;

namespace SortsTest.Sorts
{
    abstract class AbstractSort<T, TK>
        where TK : IList<T>
    {
        protected void Swap(int first, int second, TK list)
        {
            object obj = list[first];
            list[first] = list[second];
            list[second] = (T)obj;
        }

        abstract public void Sort(TK collection, IComparer<T> comparator);
    }
}
