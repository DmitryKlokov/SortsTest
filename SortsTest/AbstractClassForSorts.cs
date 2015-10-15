using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    abstract class AbstractClassForSorts<T>
    {
        protected T[] collection;

        public List<T> Sort(List<T> collection)
        {
            this.collection = collection.ToArray();
            algorithm();
            return this.collection.ToList<T>();
        }
        protected abstract void algorithm();
    }
}
