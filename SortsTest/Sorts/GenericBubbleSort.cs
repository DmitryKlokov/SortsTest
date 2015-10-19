using System;
using System.Collections.Generic;
using System.Linq;

namespace SortsTest.Sorts
{
    class GenericBubbleSort<T, TK> : AbstractSort<T, TK>
        where TK : IList<T>
    {
        public override void Sort(TK collection, IComparer<T> comparator)
        {
            for (int i = 0; i < collection.Count(); i++)
            {
                for (int j = i + 1; j < collection.Count(); j++)
                {
                    if (comparator.Compare(collection[i],collection[j]) >0)
                    {                        
                        Swap(i, j, collection);
                    }
                }
            }
        }


    }
}
