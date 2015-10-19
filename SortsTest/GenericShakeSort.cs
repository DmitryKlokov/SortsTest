using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericShakeSort<T, K> : AbstractSort<T, K>
        where T : IComparable
        where K : IList<T>
    {
        public override void Sort(K collection)
        {
            for (int i = 0; i < collection.Count() / 2; i++)
            {
                int beg = 0;
                int end = collection.Count() - 1;
                do
                {
                    if (collection[beg].CompareTo(collection[beg+1]) >0)
                    {
                        swap( beg, beg + 1,collection);
                    }
                    beg++;

                    if (collection[end - 1].CompareTo(collection[end]) >0)
                    {
                        swap( end - 1, end,collection);
                    }
                    end--;
                } while (beg <= end);
            }
        }
    }
}
