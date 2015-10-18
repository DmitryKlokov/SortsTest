using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericQuickSort<T, K> : AbstractSorts<T, K>
        where T : IComparable
        where K : IList<T>
    {
            protected override void algorithm()
            {
                quicksort( 0, collection.Count-1);
            }

            int partition(int a, int b)
            {
                int i = a;
                for (int j = a; j <= b; j++)         // просматриваем с a по b
                {
                    if (collection.ElementAt(j).CompareTo(collection.ElementAt(b)) <= 0)  // если элемент m[j] не превосходит m[b],
                    {
                        swap(i, j, collection);                 // меняем местами m[j] и m[a], m[a+1], m[a+2] и так далее...
                                                       // то есть переносим элементы меньшие m[b] в начало,
                                                      // а затем и сам m[b] «сверху»
                        i++;                         // таким образом последний обмен: m[b] и m[i], после чего i++
                    }
                }
                return i - 1;                        // в индексе i хранится <новая позиция элемента m[b]> + 1
            }

            void quicksort(int a, int b)         // a - начало подмножества, b - конец
            {                                        // для первого вызова: a = 0, b = <элементов в массиве> - 1
                if (a >= b) return;
                int c = partition( a, b);
                quicksort( a, c - 1);
                quicksort( c + 1, b);
            }

    }
}
