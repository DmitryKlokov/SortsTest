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
            //TestClass();
            TestMassInt();
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
            li1 = gsb.Sort(li1);
            ShowList<int>(li1);
            stopTimer("\nBubble");

            startTimer();
            //ShakeSort
            GenericShakeSort<int, List<int>> gss = new GenericShakeSort<int, List<int>>();
            li2 = gss.Sort(li2);
            ShowList<int>(li2);
            stopTimer("\nShake");

            startTimer();
            //HeapSort
            GenericQuickSort<int, List<int>> gqs = new GenericQuickSort<int, List<int>>();
            li3 = gqs.Sort(li3);
            ShowList<int>(li3);
            stopTimer("\nQuick");
        }

        public static void TestClass()
        {
            List<Class1> li1 = new List<Class1>();
            List<Class1> li2 = new List<Class1>();
            List<Class1> li3 = new List<Class1>();
            Random r = new Random();
            for (int i = 0; i < 200; i++)
            {
                int a = r.Next(100, 1000);
                li1.Add(new Class1( a));
                li2.Add(new Class1(a));
                li3.Add(new Class1(a));
            }

            Console.Write("\nBefore\n");
            ShowList<Class1>(li1);

            startTimer();
            //bubble
            GenericBubbleSort<Class1, List<Class1>> gsb = new GenericBubbleSort<Class1, List<Class1>>();
            li1 = gsb.Sort(li1);
            ShowList<Class1>(li1);
            stopTimer("\nBubble");

            startTimer();
            //ShakeSort
            GenericShakeSort<Class1, List<Class1>> gss = new GenericShakeSort<Class1, List<Class1>>();
            li2 = gss.Sort(li2);
            ShowList<Class1>(li2);
            stopTimer("\nShake");

            startTimer();
            //HeapSort
            GenericQuickSort<Class1, List<Class1>> ghs = new GenericQuickSort<Class1, List<Class1>>();
            li3 = ghs.Sort(li3);
            ShowList<Class1>(li3);
            stopTimer("\nQuick");
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

            startTimer();
            //bubble
            GenericBubbleSort<int, int[]> gsb = new GenericBubbleSort<int, int[]>();
            mass1 = gsb.Sort(mass1);
            ShowMass<int>(mass1);
            stopTimer("\nBubble");

            startTimer();
            //ShakeSort
            GenericShakeSort<int, int[]> gss = new GenericShakeSort<int, int[]>();
            mass2 = gss.Sort(mass2);
            ShowMass<int>(mass2);
            stopTimer("\nShake");

            startTimer();
            //HeapSort
            GenericQuickSort<int, int[]> gqs = new GenericQuickSort<int, int[]>();
            mass3 = gqs.Sort(mass3);
            ShowMass<int>(mass3);
            stopTimer("\nQuick");
        }
    }
}
