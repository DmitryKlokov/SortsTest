using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace SortsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestINT();
            //TestUserType();
            TestMassInt();
            List<char> lc = new List<char>() { 'a', 'g', 'b', 'f', 'c' };
            GenericHeapSort<char, List<char>> gsb = new GenericHeapSort<char, List<char>>();
            gsb.Sort(lc);
            ShowList<char>(lc);
        }
        static Stopwatch stopWatch = new Stopwatch();

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



        public static void startTimer()
        {
            stopWatch.Reset();
            stopWatch.Start(); 
        }
        public static void stopTimer(string name)
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine(name+" " + elapsedTime.ToString());
        }




        public static void TestINT()
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
            ShowList<int>(li1);

            startTimer();
            //bubble
            GenericBubbleSort<int, List<int>> gsb = new GenericBubbleSort<int, List<int>>();
            gsb.Sort(li1);
            ShowList<int>(li1);
            stopTimer("\nBubble");

            startTimer();
            //ShakeSort
            GenericShakeSort<int, List<int>> gss = new GenericShakeSort<int, List<int>>();
            gss.Sort(li2);
            ShowList<int>(li2);
            stopTimer("\nShake");

            startTimer();
            //HeapSort
            GenericHeapSort<int, List<int>> gqs = new GenericHeapSort<int, List<int>>();
            gqs.Sort(li3);
            ShowList<int>(li3);
            stopTimer("\nHeap");
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
            ShowList<UserType>(li1);

            startTimer();
            //bubble
            GenericBubbleSort<UserType, List<UserType>> gsb = new GenericBubbleSort<UserType, List<UserType>>();
            gsb.Sort(li1);
            ShowList<UserType>(li1);
            stopTimer("\nBubble");

            startTimer();
            //ShakeSort
            GenericShakeSort<UserType, List<UserType>> gss = new GenericShakeSort<UserType, List<UserType>>();
            gss.Sort(li2);
            ShowList<UserType>(li2);
            stopTimer("\nShake");

            startTimer();
            //HeapSort
            GenericHeapSort<UserType, List<UserType>> ghs = new GenericHeapSort<UserType, List<UserType>>();
            ghs.Sort(li3);
            ShowList<UserType>(li3);
            stopTimer("\nHeap");
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

            Console.Write("Before\n");
            ShowMass<int>(mass1);
            Console.Write("\n\n");
            startTimer();
            //bubble
            GenericBubbleSort<int, int[]> gsb = new GenericBubbleSort<int, int[]>();
            gsb.Sort(mass1);
            ShowMass<int>(mass1);
            stopTimer("\nBubble");

            startTimer();
            //ShakeSort
            GenericShakeSort<int, int[]> gss = new GenericShakeSort<int, int[]>();
            gss.Sort(mass2);
            ShowMass<int>(mass2);
            stopTimer("\nShake");

            startTimer();
            //HeapSort
            GenericHeapSort<int, int[]> gqs = new GenericHeapSort<int, int[]>();
            gqs.Sort(mass3);
            ShowMass<int>(mass3);
            stopTimer("\nHeap");
        }
    }
}
