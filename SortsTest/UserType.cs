using System;

namespace SortsTest
{
    public class UserType
    {
        public int Value;

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
