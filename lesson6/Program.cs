// using System;
// using csharpNamespace;

// class UsingDirectives
// {
//     public static void Main()
//     {
//         myExample.print();
//     }
// }

// namespace csharpNamespace
// {
//     class myExample
//     {
//         public static void print()
//         {
//             Console.WriteLine("Example of using a using directive.");
//         }
//     }
// }


/* Alias */

// using System;
// using aliasName = csharpNamespace.myExample;

// class UsingDirectives
// {
//     public static void Main()
//     {
//        aliasName.print();
//     }
// }

// namespace csharpNamespace
// {
//     class myExample
//     {
//         public static void print()
//         {
//             Console.WriteLine("Example of using a using directive.");
//         }
//     }
// }

/* Exercise 1 */
// Create a new public class named Auto with two public string properties: make and model.
// The Auto class should have a default constructor and a constructor that accepts two arguments, 1 for each of the properties; make should be the first parameter.
// The class should be contained within the Vehicles namespace.
// The Vehicles namespace should be contained within the Transportation namespace.

// using System;
// namespace Transportation {
//     namespace Vehicles {
//         class Auto {
//             public string make;
//             public string model;

//             public Auto() {
//                 this.make = "";
//                 this.model = "";
//             }

//             public Auto(string make, string model) {
//                 this.make = make;
//                 this.model = model;
//             }
//         }
//     }
// }

/* Exercise 2 */


// In the Test class, create a method named TestWidget that accepts a single Widget object as a parameter and increments the object's viewed property by 1. This method returns nothing (void).
// The definition of the Widget class is below. Do not add this to your code.
// You will need to account for the namespace of the Widget object, considering the test code you are adding is in a different namespace.
// namespace MyNamespace {
//     namespace MyObjects {
//         public class Widget {
//             public int viewed;

//             public Widget() {
//                 this.viewed = 0;
//             }
//         }
//     }
// }

/* Answer */
// Using System;
// namespace Exercise {
//     using MyNameSpace.MyObjects;
//     public class Test {
//         public void TestWidget(Widget w){
//             w.viewed++;
//         }
//     }
// }