using System;
using System.Collections.Generic;

namespace SortsTest.Comparer
{
    class DefaultComparer<T>: IComparer<T>
        where T:IComparable
    {
        public int Compare(T v1, T v2)
        {
            return v1.CompareTo(v2);
        }
    }
}
