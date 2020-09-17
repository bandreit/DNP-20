using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Vasea", "Calpazan", 23, 1.62, false, 'M', new string[] {"Boxing", "Gaming"});
            Person person2 = new Person("Fedea", "Murguov", 30, 1.76, true, 'M', new string[] {"Cars", "Eating"});
            Person person3 = new Person("Marusea", "Bilcici", 40, 1.65, true, 'F', new string[] {"Cooking", "Gardening"});
            List<Person> listOfPersons = new List<Person>();
            listOfPersons.Add(person1);
            listOfPersons.Add(person2);
            listOfPersons.Add(person3);

            string jsonFormatted = JsonSerializer.Serialize(listOfPersons, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Console.Out.WriteLine(jsonFormatted);
        }
    }
}