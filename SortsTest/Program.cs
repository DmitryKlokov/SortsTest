using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        public static void ShowList<T>(List<T> list)
        {            
            foreach (T i in list)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.Write("\n\n\n");
        }



        public static void Test()
        {
            List<int> li1 = new List<int>() { 1,43,54,4,67,888,3,2,4,6,65,34,23,36,23,52};
            List<int> li2 = new List<int>() { 1, 43, 54, 4, 67, 888, 3, 2, 4, 6, 65, 34, 23, 36, 23, 52 };
            List<int> li3 = new List<int>() { 1, 43, 54, 4, 67, 888, 3, 2, 4, 6, 65, 34, 23, 36, 23, 52 };

            Console.Write("Before\n");
            ShowList<int>(li1);

            //bubble
            GenericSortBubble<int> gsb = new GenericSortBubble<int>();
            li1 = gsb.Sort(li1);
            ShowList<int>(li1);

            //ShakeSort
            GenericShakeSort<int> gss = new GenericShakeSort<int>();
            li2 = gss.Sort(li2);
            ShowList<int>(li2);

            GenericHeapSort<int> ghs = new GenericHeapSort<int>();
            li3 = ghs.Sort(li3);
            ShowList<int>(li3);
        }
    }
}
