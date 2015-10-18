using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    public class UserType:IComparable
    {
        public int value;

        public int CompareTo(object v)
        {
            return value.CompareTo((v as UserType).value);
        }

        public UserType(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
    
}
