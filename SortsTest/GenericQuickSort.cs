using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericQuickSort<T> : AbstractClassForSorts<T>
    {
        protected override void algorithm()
        {
            //RecAlgorithm(collection,0,collection.Count());
        }
        private void RecAlgorithm(T[] collection, int l, int r)
        {
            T temp;
            T x = collection[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
              //->  while (collection[i] < x) i++;
              //->  while (collection[j] > x) j--;
                if (i <= j)
                {
                    temp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                RecAlgorithm(collection, i, r);

            if (l < j)
                RecAlgorithm(collection, l, j);
        }
    }
}
