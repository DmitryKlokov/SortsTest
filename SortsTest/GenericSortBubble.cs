using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericSortBubble<T> : AbstractClassForSorts<T> where T : IComparable
    {
        protected override void algorithm()
        {
            for (int i = 0; i < collection.Count() - 1; i++)
            {
                for (int j = i + 1; j < collection.Count(); j++)
                {
                    if (collection[i].CompareTo(collection[j]) == 1)
                    {
                        T tmp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = tmp;
                    }
                }
            }
        }

    }
}
