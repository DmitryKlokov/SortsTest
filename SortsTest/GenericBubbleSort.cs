using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class GenericBubbleSort<T, K> : AbstractSorts<T, K>
        where T : IComparable
        where K : IList<T>
    {
        protected override void algorithm()
        {
            for (int i = 0; i < collection.Count() - 1; i++)
            {
                for (int j = i + 1; j < collection.Count(); j++)
                {
                    if (collection.ElementAt(i).CompareTo(collection.ElementAt(j)) == 1)
                    {
                        swap(i, j, collection);
                    }
                }
            }
        }


    }
}
