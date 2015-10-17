using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericHeapSort<T> : AbstractClassForSorts<T> where T : IComparable
    {
            protected override void algorithm()
            {
               for (int i = collection.Count() / 2 - 1; i >= 0; i--)
                {
                    ShiftDown(collection, i, collection.Count());
                }
                for (int i = collection.Count() - 1; i >= 1; i--)
                {
                    T temp = collection[0];
                    collection[0] = collection[i];
                    collection[i] = temp;
                
                    ShiftDown(collection, 0, i);
                }
            }

            private void ShiftDown(T[] collection, int i, int j)
            {
                bool done = false;

                while ((i*2 + 1 < j) && (!done))
                {
                    int maxChild;
                
                    if (i*2 + 1 == j - 1)
                    {
                        maxChild = i*2 + 1;
                    }
                    else if (collection[i*2 + 1].CompareTo(collection[i*2 + 2]) == 1)
                    {
                        maxChild = i*2 + 1;
                    }
                    else
                    {
                        maxChild = i*2 + 2;
                    }
                    if (collection[i].CompareTo(collection[maxChild]) == -1)
                    {
                        T temp = collection[i];
                        collection[i] = collection[maxChild];
                        collection[maxChild] = temp;
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
