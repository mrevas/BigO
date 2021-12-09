using System;
using System.Diagnostics;
using System.Linq;

namespace BigO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Linear: O(n)
            var watch = new Stopwatch();
            watch.Start();
            var arr = InitArray(10000);
            watch.Stop();
            Console.WriteLine($"InitArray() Execution Time: {watch.ElapsedMilliseconds} ms");

            //Constant: O(1)
            watch = new Stopwatch();
            watch.Start();
            var added = AddOneToIndexZero(arr);
            watch.Stop();
            Console.WriteLine($"AddOne() Execution Time: {watch.ElapsedMilliseconds} ms");

            //Logarithmic: O(log(n))
            watch.Start();
            var halfed = HalfContinuously(arr);
            watch.Stop();
            Console.WriteLine($"HalfedContinuously() Execution Time: {watch.ElapsedMilliseconds} ms");

            //LinearO(n)
            watch.Start();
            var summed = SumOfAll(arr);
            watch.Stop();
            Console.WriteLine($"SumOfAll() Execution Time: {watch.ElapsedMilliseconds} ms");

            //Quadratic: O(n^2)
            watch.Start();
            var paired = PairIntoATable(arr);
            watch.Stop();
            Console.WriteLine($"Pair() Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        //Constant: O(1)
        private static int AddOneToIndexZero(int[] a)
        {
            return 1 + a[0];
        }
        
        //Logarithmic: O(log(n))
        private static int HalfContinuously(int[] a)
        {
            var length = a.Length;
            Span<int> arr = a;
            while (arr.Length > 1)
            {
                arr = arr.Slice(0, length / 2);
                length = arr.Length;
            }
            return arr[0] * 9;
        }

        //Linear: O(n)
        private static int[] InitArray(int arrLength)
        {
            int[] arr = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        //LinearO(n)
        private static int SumOfAll(int[] a)
        {
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                x += a[i];
            }
            return x;
        }
        
        //Quadratic: O(n^2)
        private static int[][] PairIntoATable(int[] a)
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
