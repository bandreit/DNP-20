using System;

namespace S1_Ex7
{
    class Program
    {
        public static string MakeAbba(string a, string b)
        {
            return $"{a}{b}{b}{a}";
        }

        static void Main(string[] args)
        {
            Console.Out.WriteLine(
                MakeAbba("Hi", "Bye"));
            Console.Out.WriteLine(
                MakeAbba("Yo", "Alice"));
            Console.Out.WriteLine(
                MakeAbba("What", "Up"));
        }
    }
}