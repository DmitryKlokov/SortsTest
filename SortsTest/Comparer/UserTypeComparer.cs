using System.Collections.Generic;

namespace SortsTest.Comparer
{
    class UserTypeComparer<T>:IComparer<T>
        where T: UserType
    {
        public int Compare(T v1, T v2)
        {
            if (v1.Value == v2.Value) return 0;
            if (v1.Value < v2.Value) return -1;
            return 1;
        }
    }
}
