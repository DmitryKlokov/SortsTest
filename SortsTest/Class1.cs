using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    public class Class1:IComparable
    {
        public int value;

        public int CompareTo(object v)
        {
            return value.CompareTo((v as Class1).value);
        }

        public Class1(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
    
}
