using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericQuickSort<T> : AbstractClassForSorts<T> where T : IComparable
    {
        protected override void algorithm()
        {
            RecAlgorithm(collection,0,collection.Count()-1);
        }
        private void RecAlgorithm(T[] collection, int left, int right)
        {
            int i = left, j = right;
            T pivot = collection[(left + right) / 2];
            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (collection[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    // Swap
                    T tmp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = tmp;
                    i++;
                    j--;
                }
            }
            // Recursive calls
            if (left < j)
            {
                RecAlgorithm(collection, left, j);
            }
            if (i < right)
            {
                RecAlgorithm(collection, i, right);
            }
        }
    }
}
