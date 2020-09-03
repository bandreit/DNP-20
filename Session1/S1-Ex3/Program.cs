using System;

namespace S1_Ex1
{
    class Person
    {
        public string Name;

        public void Introduce()
        {
            Console.Out.WriteLine($"Hi, I am {Name}");
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Andrei";
            person.Introduce();
        }
    }
}    