using System;
using System.Collections.Generic;
using System.Linq;
using SortsTest.Comparator;

namespace SortsTest.Sorts
{
    class GenericHeapSort<T, TK> : AbstractSort<T, TK>
        where TK : IList<T>
    {
        private IComparator<T> comparator;
        public override void Sort(TK collection, IComparator<T> comparator)
        {
            this.comparator = comparator;
            for (int i = collection.Count() / 2 - 1; i >= 0; i--)
            {
                ShiftDown(collection, i, collection.Count());
            }
            for (int i = collection.Count() - 1; i >= 1; i--)
            {
                Swap(0, i, collection);

                ShiftDown(collection, 0, i);
            }
        }
        private void ShiftDown(TK collection, int i, int j)
        {
            bool done = false;

            while ((i * 2 + 1 < j) && (!done))
            {
                int maxChild;

                if (i * 2 + 1 == j - 1)
                {
                    maxChild = i * 2 + 1;
                }
                else if (comparator.CompareTo(collection[i * 2 + 1],collection[i * 2 + 2]) >0)
                {
                    maxChild = i * 2 + 1;
                }
                else
                {
                    maxChild = i * 2 + 2;
                }
                if (comparator.CompareTo(collection[i],collection[maxChild]) <0)
                {
                    Swap(i, maxChild, collection);
                    i = maxChild;
                }
                else
                {
                    done = true;
                }
            }
        }
    }
}
