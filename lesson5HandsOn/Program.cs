using System;

namespace lesson5HandsOn
{
    public class Person
    {
        // Part 1
        string firstName;
        string lastName;
        int age;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                // Part 3
                if (value < 0)
                {
                    Console.WriteLine("Attempted to set age to an invalid value. Set age to 0 instead.");
                }
                else
                {
                    age = value;
                }
            }
        }
        // Part 2 default constructor
        public Person()
        {
            firstName = "";
            lastName = "";
            age = 0;
        }
        public Person(string personFirstName, string personLastName, int personAge)
        {
            firstName = personFirstName;
            lastName = personLastName;
            age = personAge;

            // Part 3
            if (age < 0)
            {
                Console.WriteLine("Attempted to set age to an invalid value. Set age to 0 instead.");
                age = 0;
            }
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Henry", "Boswald", 33);
            Person p2 = new Person("Lola", "Boswald", 31);
            Person p3 = new Person();
            Person p4 = new Person();

            p3.FirstName = "Emilia";
            p3.LastName = "Hill";
            p3.Age = -42;

            p4.FirstName = "Lucius";
            p4.LastName = "Hill";
            p4.Age = 45;


            Console.WriteLine(p3.FirstName + " " + p3.LastName + " is " + p3.Age + " years old.");
            Console.WriteLine(p4.FirstName + " " + p4.LastName + " is " + p4.Age + " years old.");

        }
    }
}
