using System;

namespace S1_Ex8
{
    class Program
    {
        public static string MakeOuterWord(string outer, string word)
        {
            return $"{outer.Substring(0, 2)}{word}{outer.Substring(2, 2)}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MakeOuterWord("<<>>", "Yay"));
            Console.WriteLine(MakeOuterWord("<<>>", "WooHoo"));
            Console.WriteLine(MakeOuterWord("[[]]", "word"));
        }
    }
}