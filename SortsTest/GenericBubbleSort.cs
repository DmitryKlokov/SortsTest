using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericBubbleSort<T, K>: Swaper<T>, ISorts<T, K>
        where T : IComparable
        where K : IList<T>
    {
        public void Sort(K collection)
        {
            for (int i = 0; i < collection.Count() - 1; i++)
            {
                for (int j = i + 1; j < collection.Count(); j++)
                {
                    if (collection[i].CompareTo(collection[j]) == 1)
                    {                        
                        swap(i, j, collection);
                    }
                }
            }
        }


    }
}
