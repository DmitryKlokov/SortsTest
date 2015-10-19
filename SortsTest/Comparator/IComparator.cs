namespace SortsTest.Comparator
{
    interface IComparator<T>
    {
        int CompareTo(T v1, T v2);
    }
}
