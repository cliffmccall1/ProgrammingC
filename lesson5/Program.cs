/********************* exercise 1 **************************/

// using System;

// namespace lesson5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             {
//                 string firstName = "Andrew";
//                 string lastName = "Coder";
//                 string courseFocus = "C#";
//                 Console.WriteLine(firstName + " " + lastName + " is studying " + courseFocus);
//             }
//             {
//                 string firstName = "Anders";
//                 string lastName = "Hejlsberg";
//                 string courseFocus = "C#";
//                 Console.WriteLine(firstName + " " + lastName + " is studying " + courseFocus);

//             }
//         }
//     }
// }

/********************* exercise 2 **************************/

// using System;

// namespace lesson5
// {

//     public class Student
//     {
//         string firstName;
//         string lastName;
//         string courseFocus;
//         // constructor
//         public Student()
//         {
//             firstName = "";
//             lastName = "";
//             courseFocus = "";
//         }
//         // Parameterized constructor - constructor overloading
//         public Student(string first, string last, string focus)
//         {
//             firstName = first;
//             lastName = last;
//             courseFocus = focus;

//             Console.WriteLine(firstName + " " + lastName + " is studying " + courseFocus);
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // New student object instantiated 
//             Student student1 = new Student();
//             Student student2 = new Student("James", "Gosling", "C#");
//         }
//     }
// }

/********************* exercise 3 **************************/

using System;

namespace myApp
{
    class Student
    {
        string firstName;
        string lastName;
        string courseFocus;

        // Declare a First Name property of type string
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

        // Declare a LastName Property of type string
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
        // Declare a CourseFocus property of type string
        public string CourseFocus
        {
            get
            {
                return courseFocus;
            }
            set
            {
                courseFocus = value;
            }
        }
        public override string ToString()
        {
            return firstName + " " + lastName + " has the Course Focus of " + courseFocus;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            /********* Example *******/
            // Student s = new Student();
            // s.CourseFocus = "C#";
            // s.FirstName = "John";
            // s.LastName = "Slaw";
            // Console.WriteLine("Student info: {0}", s);

            /********* Practice *******/
            // instantiate three student objects
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            // set the information for student 1
            s1.CourseFocus = "C#";
            s1.FirstName = "Cliff";
            s1.LastName = "Mccall";
            // set the information for student 2
            s2.CourseFocus = "JavaScript";
            s2.FirstName = "Regina";
            s2.LastName = "Briggs";
            // set the information for student 3
            s3.CourseFocus = "Java";
            s3.FirstName = "Amanda";
            s3.LastName = "Dann";
            // print information for each student
            Console.WriteLine("Student info: {0}", s1);
            Console.WriteLine("Student info: {0}", s2);
            Console.WriteLine("Student info: {0}", s3);
        }
    }
}

/********** Classes Activity 1 of 2 ***********/
// Task 1 of 2
// Given the Person class below, create a public Greeter class with a single static method named Greet. This method should:
// Accept one parameter named people that is an array of Person objects.
// Create an array of greetings (strings). There will be one greeting per person. Each should say "Hello FIRST LAST!", where "FIRST" and "LAST" are replaced with the values from the person (firstName and lastName).
// Return the array of greetings.
// For instance, if the input to the static Greet method of the Greeter class were two people named "Bill Barnes" and "Sally Smith", the result would be an array of two strings:

// using System;
// namespace Exercise {
//     public class Greeter {
//         public static string[] Greet(Person[] people) {
//             string[] results = new string[people.Length];
//             for(int i = 0; i < people.Length; i++) {
//                 Person p = people[i];
//                 results[i] = "Hello " + p.firstName + " " + p.lastName + "!";
//             }
//             return results;
//         }
//     }
// }

// Task 2 of 2
// In the Person class, add three property accessors:
// A FirstName accessor that is a string that is responsible for getting and setting the protected firstName member variable.
// A LastName accessor that is a string that is responsible for getting and setting the protected lastName member variable.
// A FullName accessor that is a string that returns the first name concatenated with the last name with a space in between for its getter. There should be no setter.

// using System;
// namespace Exercise
// {
//     public class Person
//     {
//         string firstName;
//         string lastName;

//         // TODO: Accessors
//         public string FirstName
//         {
//             get
//             {
//                 return firstName;
//             }
//             set
//             {
//                 firstName = value;
//             }
//         }
//         public string LastName
//         {
//             get
//             {
//                 return lastName;
//             }
//             set
//             {
//                 lastName = value;
//             }
//         }
//         public string FullName
//         {
//             get
//             {
//                 return FirstName + " " + LastName;
//             }
//         }
//         public Person()
//         {
//             this.firstName = "";
//             this.lastName = "";
//         }
//         public Person(string firstName, string lastName)
//         {
//             this.firstName = firstName;
//             this.lastName = lastName;
//         }
//     }
// }