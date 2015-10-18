using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    public class Swaper<T>
    {
        public void swap(int first, int second, IList<T> list)
        {
            object obj = list[first];
            list[first] = list[second];
            list[second] = (T)obj;
        }
    }
}
