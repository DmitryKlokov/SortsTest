using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    abstract class AbstractSorts<T, K>
        where K : IList<T>
    {
        protected K collection;
        
        public K Sort(K collection) 
        {
            this.collection = collection;
            algorithm();
            return this.collection;
        }


        public void swap( int first, int second, IList<T> list)
        {
            object obj = list[first];
            list[first] = list[second];
            list[second] = (T)obj;
        }

        protected abstract void algorithm();
    }
}
