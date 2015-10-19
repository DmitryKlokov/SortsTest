using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    abstract class AbstractSort<T, K>
        where T : IComparable
        where K : IList<T>
    {
        protected void swap(int first, int second, K list)
        {
            object obj = list[first];
            list[first] = list[second];
            list[second] = (T)obj;
        }

        abstract public void Sort(K collection);
    }
}
