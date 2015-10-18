using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    interface ISorts<T, K>
        where T : IComparable
        where K : IList<T>
    {
        void Sort(K collection);
    }
}
