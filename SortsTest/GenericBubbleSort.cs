using System;
using System.Collections.Generic;
using System.Linq;

namespace SortsTest
{
    class GenericBubbleSort<T, TK> : AbstractSort<T, TK>
        where T : IComparable
        where TK : IList<T>
    {
        public override void Sort(TK collection)
        {
            for (int i = 0; i < collection.Count(); i++)
            {
                for (int j = i + 1; j < collection.Count(); j++)
                {
                    if (collection[i].CompareTo(collection[j]) >0)
                    {                        
                        Swap(i, j, collection);
                    }
                }
            }
        }


    }
}
