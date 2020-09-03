using System;

namespace S1_Ex9
{
    class Program
    {
        public static string PrintFirstAndLastNCharacters(string s, int n)
        {
            return $"{s.Substring(0, n)}{s.Substring(s.Length - n, n)}";
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(PrintFirstAndLastNCharacters("Hello", 2));
            Console.WriteLine(PrintFirstAndLastNCharacters("Chocolate", 3));
            Console.WriteLine(PrintFirstAndLastNCharacters("Chocolate", 1));
        }
    }
}