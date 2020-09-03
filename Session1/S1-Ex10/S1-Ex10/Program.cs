using System;
using System.Linq;

namespace S1_Ex10
{
    class Program
    {
        static int ReturnDifferenceBetweenMinAndMax(int[] arr)
        {
            // return arr.Max() - arr.Min();
            
            // OR

            var min = arr[0];
            var max = arr[0];

            foreach (var e in arr)
            {
                if (e < min)
                {
                    min = e;
                }

                if (e > max)
                {
                    max = e;
                }
            }

            return max - min;
        }

        static void Main(string[] args)
        {
            Console.Out.WriteLine(ReturnDifferenceBetweenMinAndMax(
                new int[] {10, 3, 5, 6}));
            Console.Out.WriteLine(ReturnDifferenceBetweenMinAndMax(
                new int[] {7, 2, 10, 9}));
            Console.Out.WriteLine(ReturnDifferenceBetweenMinAndMax(
                new int[] {2, 10, 7, 2}));
        }
    }
}