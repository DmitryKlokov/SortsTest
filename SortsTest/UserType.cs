using System;

namespace SortsTest
{
    public class UserType:IComparable
    {
        public int Value;

        public int CompareTo(object v)
        {
            return Value.CompareTo(((UserType) v).Value);
        }

        public UserType(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
    
}
