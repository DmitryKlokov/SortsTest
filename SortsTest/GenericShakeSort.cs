using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericShakeSort<T> : AbstractClassForSorts<T> where T : IComparable
    {
        protected override void algorithm()
        {
            for (int i = 0; i < collection.Count() / 2; i++)
            {
                int beg = 0;
                int end = collection.Count() - 1;

                do
                {
                    if (collection[beg].CompareTo(collection[beg + 1]) == 1)
                    {
                        Swap(collection, beg, beg + 1);
                    }
                    beg++;

                    if (collection[end - 1].CompareTo(collection[end]) == 1)
                    {
                        Swap(collection, end - 1, end);
                    }
                    end--;

                } while (beg <= end);
            }
        }
        private void Swap(T[] collection, int i, int j)
        {
            T item = collection[i];
            collection[i] = collection[j];
            collection[j] = item;
        }
    }
}
