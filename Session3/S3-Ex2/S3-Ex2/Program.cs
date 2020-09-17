using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

            StoreObjects(listOfPersons);
            ReadFile().ForEach(Console.WriteLine);
        }

        static void StoreObjects(List<Person> persons)
        {
            using (StreamWriter file = new StreamWriter("Persons.txt"))
            {
                foreach (Person person in persons)
                {
                    file.WriteLine(JsonSerializer.Serialize(person));
                }
            }
        }

        static List<Person> ReadFile()
        {
            List<Person> listOfPersons = new List<Person>();
            using (StreamReader sr = new StreamReader("Persons.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Person person = JsonSerializer.Deserialize<Person>(line);
                    listOfPersons.Add(person);
                }
            }

            return listOfPersons;
        }
    }
}