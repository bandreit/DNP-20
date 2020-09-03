using System;

namespace S1_Ex5.MathLib
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int[] arr)
        {
            int s = 0;

            foreach (var a in arr)
            {
                s += a;
            }

            return s;
        }

        public int ReturnMax()
        {
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            return a < b ? b : a;
        }
    }
}