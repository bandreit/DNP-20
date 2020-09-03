using System;

namespace S1_Ex11
{
    class Program
    {
        static int ReturnNumberOfClampsInArray(int[] arr)
        {
            var clumps = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    clumps++;
                    for (int j = i + 2; j <= arr.Length - 1; j++)
                    {
                        if (j == arr.Length - 1)
                        {
                            i = arr.Length - 1;
                            break;
                        }
                        if (arr[i] != arr[j])
                        {
                            i = j - 1;
                            break;
                        }
                    }
                }
            }

            return clumps;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReturnNumberOfClampsInArray(new int[] {1, 2, 2, 2, 3, 3, 3, 3, 4, 4 ,4}));
            Console.WriteLine(ReturnNumberOfClampsInArray(new int[] {1, 1, 2, 1, 1, 1, 1, 1, 1, 2, 2, 1, 2, 2}));
            Console.WriteLine(ReturnNumberOfClampsInArray(new int[] {1, 1, 1, 1, 1}));
        }
    }
}