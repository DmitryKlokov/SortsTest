using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericHeapSort<T, K> : Swaper<T>, ISorts<T, K>
        where T : IComparable
        where K : IList<T>
    {
        public void Sort(K collection)
        {
            for (int i = collection.Count() / 2 - 1; i >= 0; i--)
            {
                ShiftDown(collection, i, collection.Count());
            }
            for (int i = collection.Count() - 1; i >= 1; i--)
            {
                swap(0, i, collection);

                ShiftDown(collection, 0, i);
            }
        }
        private void ShiftDown(K collection, int i, int j)
        {
            bool done = false;

            while ((i * 2 + 1 < j) && (!done))
            {
                int maxChild;

                if (i * 2 + 1 == j - 1)
                {
                    maxChild = i * 2 + 1;
                }
                else if (collection[i * 2 + 1].CompareTo(collection[i * 2 + 2]) >0)
                {
                    maxChild = i * 2 + 1;
                }
                else
                {
                    maxChild = i * 2 + 2;
                }
                if (collection[i].CompareTo(collection[maxChild]) <0)
                {
                    swap(i, maxChild, collection);
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
