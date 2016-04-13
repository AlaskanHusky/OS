using System;
using System.Threading;
using System.Diagnostics;

namespace Multithreading
{
    class Program
    {
        static void RandomArray(double[] arr)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(Int16.MaxValue, Int32.MaxValue);
            }
        }
        static void ShowArray(double[] arr)
        {
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" {0}", arr[i]); 
            }
        }
        static void Involution(double[] a, double[] b, int k, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    b[i] += Math.Pow(a[i], 1.789);
                }
            }
        }
        static void Main(string[] args)
        {
            double[] a;
            double[] b;
            double[] c;
            Stopwatch sw = new Stopwatch();
            Console.Write("Input array size: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input difficulty parameter: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Input count of threads: ");
            int tCount = int.Parse(Console.ReadLine());
            int length = n / tCount;
            a = new double[n];
            b = new double[n];
            c = new double[n];
            RandomArray(a);
            sw.Start();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    b[i] += Math.Pow(a[i], 1.789);
                }
            }
            sw.Stop();
            Console.WriteLine("Operation time: {0} quantums - consistent threads", sw.ElapsedTicks);
            sw.Reset();
            sw.Start();
            Thread[] threads = new Thread[tCount];
            for (int i = 0; i < threads.Length - 1; i++)
			{
                threads[i] = new Thread(() => { Involution(a, c, k, i * length, (i + 1) * length); });
                threads[i].Start();
            }
            threads[tCount - 1] = new Thread(() => { Involution(a, c, k, (tCount - 1) * length, n); });
            threads[tCount - 1].Start();
            foreach (Thread t in threads)
            {
                t.Join();
            }
            sw.Stop();
            Console.WriteLine("Operation time: {0} quantums - multithreading", sw.ElapsedTicks);
            Console.ReadKey(true);
        }
    }
}
