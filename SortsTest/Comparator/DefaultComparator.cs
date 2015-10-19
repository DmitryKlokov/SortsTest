using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest.Comparator
{
    class DefaultComparator<T>: IComparator<T>
        where T:IComparable
    {
        public int CompareTo(T v1, T v2)
        {
            return v1.CompareTo(v2);
        }
    }
}
