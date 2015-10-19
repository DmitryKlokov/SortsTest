using System;
using System.Collections.Generic;
using System.Linq;

namespace SortsTest
{
    class GenericShakeSort<T, TK> : AbstractSort<T, TK>
        where T : IComparable
        where TK : IList<T>
    {
        public override void Sort(TK collection)
        {
            for (int i = 0; i < collection.Count() / 2; i++)
            {
                int beg = 0;
                int end = collection.Count() - 1;
                do
                {
                    if (collection[beg].CompareTo(collection[beg+1]) >0)
                    {
                        Swap( beg, beg + 1,collection);
                    }
                    beg++;

                    if (collection[end - 1].CompareTo(collection[end]) >0)
                    {
                        Swap( end - 1, end,collection);
                    }
                    end--;
                } while (beg <= end);
            }
        }
    }
}
