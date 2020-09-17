using System;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public bool IsMarried { get; set; }
        public char Sex { get; set; }
        public string[] Hobbies { get; set; }

        public Person(string firstName, string lastName, int age, double height, bool isMarried, char sex, string[] hobbies)
        {    
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            IsMarried = isMarried;
            Sex = sex;
            Hobbies = hobbies;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            string hobbies = "";
            foreach (var t in Hobbies)
            {
                hobbies += t + " ";
            }
            return $"{FirstName} {LastName} \n" +
                   $"{Age} yo \n" +
                   $"{Height} m \n" +
                   $"{Sex}\n" +
                   $"{hobbies}\n";
        }
    }
}