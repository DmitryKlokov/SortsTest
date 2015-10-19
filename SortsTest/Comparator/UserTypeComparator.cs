namespace SortsTest.Comparator
{
    class UserTypeComparator<T>:IComparator<T>
        where T: UserType
    {
        public int CompareTo(T v1, T v2)
        {
            if (v1.Value == v2.Value) return 0;
            if (v1.Value < v2.Value) return -1;
            return 1;
        }
    }
}
