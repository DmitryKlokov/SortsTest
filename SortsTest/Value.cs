using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class Value<T>
    {
        public T value;
        public int CompareTo(T obj)
        {
            return 1;
        }
    }
}
