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
            testListInt();
        }

        public static void testListInt()
        {
            List<int> li1 = new List<int>();
            List<int> li2 = new List<int>();
            List<int> li3 = new List<int>();

            Random r = new Random();
            for (int i = 0; i < 34; i++)
            {
                int k = r.Next(0, 50);
                li1.Add(k);
                li2.Add(k);
                li3.Add(k);
            }
            Console.Write("Before\n");
            foreach (int i in li1)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.Write("\n\n\n");

            //bubble
            GenericSortBubble<int> gsb = new GenericSortBubble<int>();
            li1 = gsb.Sort(li1);
            foreach (int i in li1)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.Write("\n\n\n");

            //QuickSort
            GenericQuickSort<int> gqs = new GenericQuickSort<int>();
            li2 = gqs.Sort(li2);

            foreach (int i in li2)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.Write("\n\n");
        }
    }
}
