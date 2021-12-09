using System;
using System.Diagnostics;
using System.Linq;

namespace BigO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                arr[i] = i + 1;
            }
            var watch = new Stopwatch();
            watch.Start();
            var added = AddOne(arr);
            watch.Stop();
            Console.WriteLine($"Add() Execution Time: {watch.ElapsedMilliseconds} ms");

            watch.Start();
            var summed = Sum(arr);
            watch.Stop();
            Console.WriteLine($"Sum() Execution Time: {watch.ElapsedMilliseconds} ms");


            watch.Start();
            var paired = Pair(arr);
            watch.Stop();
            Console.WriteLine($"Pair() Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        private static int AddOne(int[] a)
        {
            return 1 + a[0];
        }
        private static int Sum(int[] a)
        {
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                x += a[i];
            }
            return x;
        }
        private static int[][] Pair(int[] a)
        {
            var array2D = new int[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                for (int x = 0; x < a.Length; x++)
                {
                    var arr = new int[] { a[i], a[x] };
                    array2D[i] = arr;
                }
            }
            return array2D;
        }
    }

}
