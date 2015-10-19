using System;
using System.Collections.Generic;
using System.Linq;

namespace SortsTest.Sorts
{
    class GenericShakeSort<T, TK> : AbstractSort<T, TK>
        where TK : IList<T>
    {
        public override void Sort(TK collection, IComparer<T> comparator )
        {
            for (int i = 0; i < collection.Count() / 2; i++)
            {
                int beg = 0;
                int end = collection.Count() - 1;
                do
                {
                    if (comparator.Compare(collection[beg],collection[beg+1]) >0)
                    {
                        Swap( beg, beg + 1,collection);
                    }
                    beg++;

                    if (comparator.Compare(collection[end - 1],collection[end]) >0)
                    {
                        Swap( end - 1, end,collection);
                    }
                    end--;
                } while (beg <= end);
            }
        }
    }
}
