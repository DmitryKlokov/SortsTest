using System;
using System.Collections.Generic;
using System.Diagnostics;
using SortsTest.Comparator;
using SortsTest.Sorts;

namespace SortsTest
{
    class Program
    {
        static void Main()
        {
            //TestInt();
            TestUserType();
            //TestMassInt();

            //List<string> lc = new List<string>() { "adffd", "sdcsd","ewewe","dsdssd","www"};
            //AbstractSort<string, List<string>> gsb = new GenericBubbleSort<string, List<string>>();
            //gsb.Sort(lc, comp );
            //ShowList(lc);
        }
        static readonly Stopwatch StopWatch = new Stopwatch();

        public static void ShowList<T>(ICollection<T> list)
        {
            Console.Write("\n\n\n");
            foreach (T i in list)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static void ShowMass<T>(T[] mass)
        {
            foreach(T t in mass)
            {
                Console.Write(t.ToString() + " ");
            }
        }
        
        public static void StartTimer()
        {
            StopWatch.Reset();
            StopWatch.Start(); 
        }
        public static void StopTimer(string name)
        {
            StopWatch.Stop();
            TimeSpan ts = StopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine(name+" " + elapsedTime);
        }
        
        public static void TestInt()
        {
            Random r = new Random();
            List<int> li1 = new List<int>();
            List<int> li2 = new List<int>();
            List<int> li3 = new List<int>();
            for (int i = 0; i < 200; i++)
            {
                int a = r.Next(100, 1000);
                li1.Add(a);
                li2.Add(a);
                li3.Add(a);
            }

            Console.Write("Before\n");
            ShowList(li1);

            IComparator<int> comparator = new DefaultComparator<int>();
            //bubble
            AbstractSort<int, List<int>> gsb = new GenericBubbleSort<int, List<int>>();
            gsb.Sort(li1, comparator);
            ShowList(li1);
            StopTimer("\nBubble");

            StartTimer();
            //ShakeSort
            AbstractSort<int, List<int>> gss = new GenericShakeSort<int, List<int>>();
            gss.Sort(li2, comparator);
            ShowList(li2);
            StopTimer("\nShake");

            StartTimer();
            //HeapSort
            AbstractSort<int, List<int>> gqs = new GenericHeapSort<int, List<int>>();
            gqs.Sort(li3, comparator);
            ShowList(li3);
            StopTimer("\nHeap");
        }
        public static void TestUserType()
        {
            List<UserType> li1 = new List<UserType>();
            List<UserType> li2 = new List<UserType>();
            List<UserType> li3 = new List<UserType>();
            Random r = new Random();
            for (int i = 0; i < 200; i++)
            {
                int a = r.Next(100, 1000);
                li1.Add(new UserType( a));
                li2.Add(new UserType(a));
                li3.Add(new UserType(a));
            }

            Console.Write("\nBefore\n");
            ShowList(li1);


            IComparator<UserType> comparator = new UserTypeComparator<UserType>();
            StartTimer();
            //bubble
            AbstractSort<UserType, List<UserType>> gsb = new GenericBubbleSort<UserType, List<UserType>>();
            gsb.Sort(li1, comparator);
            ShowList(li1);
            StopTimer("\nBubble");

            StartTimer();
            //ShakeSort
            AbstractSort<UserType, List<UserType>> gss = new GenericShakeSort<UserType, List<UserType>>();
            gss.Sort(li2, comparator);
            ShowList(li2);
            StopTimer("\nShake");

            StartTimer();
            //HeapSort
            AbstractSort<UserType, List<UserType>> ghs = new GenericHeapSort<UserType, List<UserType>>();
            ghs.Sort(li3, comparator);
            ShowList(li3);
            StopTimer("\nHeap");
        }
        public static void TestMassInt()
        {
            int[] mass1 = new int[200];
            int[] mass2 = new int[200];
            int[] mass3 = new int[200];

            Random r = new Random();
            for (int i = 0; i < 200; i++)
            {
                int a = r.Next(100, 1000);
                mass1[i] = a;
                mass2[i] = a;
                mass3[i] = a;
            }

            IComparator<int> comparator = new DefaultComparator<int>();

            Console.Write("Before\n");
            ShowMass(mass1);
            Console.Write("\n\n");
            StartTimer();
            //bubble
            AbstractSort<int, int[]> gsb = new GenericBubbleSort<int, int[]>();
            gsb.Sort(mass1, comparator);
            ShowMass(mass1);
            StopTimer("\nBubble");

            StartTimer();
            //ShakeSort
            AbstractSort<int, int[]> gss = new GenericShakeSort<int, int[]>();
            gss.Sort(mass2, comparator);
            ShowMass(mass2);
            StopTimer("\nShake");

            StartTimer();
            //HeapSort
            AbstractSort<int, int[]> gqs = new GenericHeapSort<int, int[]>();
            gqs.Sort(mass3, comparator);
            ShowMass(mass3);
            StopTimer("\nHeap");
        }
    }
}
