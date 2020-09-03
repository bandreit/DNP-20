using System;
using S1_Ex5.MathLib;

namespace S1_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            // Console.Out.WriteLine(calculator.Add(2, 2) + " <- 4");
            //
            // int[] theArray = { 1, 2, 2, 6 };
            // Console.Out.WriteLine(calculator.Add(theArray) + " <- 11");

            Console.Out.WriteLine(calculator.ReturnMax());
        }
    }
}