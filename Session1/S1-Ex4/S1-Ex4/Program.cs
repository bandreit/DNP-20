using System;

namespace S1_Ex4
{
    class Program
    {
        private static void PrintAllEvenNumbersBetweenZeroAndX(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0) Console.Out.WriteLine(i);
            }
        }
        
        private static void PrintAllOddNumbersBetweenZeroAndX(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 != 0) Console.Out.WriteLine(i);
            }
        }
        
        private static void PrintAllDivisibleByYNumbersBetweenZeroAndX(int x, int y)
        {
            for (int i = 1; i <= x; i++)
            {
                
                if (i % y == 0) Console.Out.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            // PrintAllEvenNumbersBetweenZeroAndX(10);
            // PrintAllOddNumbersBetweenZeroAndX(10);
            PrintAllDivisibleByYNumbersBetweenZeroAndX(100, 3);
        }
    }
}