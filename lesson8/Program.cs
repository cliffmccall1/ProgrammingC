using System;
using System.Collections;
using System.Collections.Generic;

namespace lesson8
{
    /* Abstract */
    // public abstract class Person
    // {
    //     public string name;
    //     public int age;

    //     public Person(string name, int age)
    //     {
    //         this.name = name;
    //         this.age = age;
    //     }

    //     public abstract void sayHello();

    //     public int getAge()
    //     {
    //         return this.age;
    //     }
    // }

    // public class Teacher : Person
    // {
    //     private string subject;

    //     public Teacher(string name, int age, string subject)
    //         : base(name, age)
    //     {
    //         setSubject(subject);
    //     }

    //     public void setSubject(string subject)
    //     {
    //         this.subject = subject;
    //     }

    //     public override void sayHello()
    //     {
    //         Console.WriteLine("Hello, my name is " + this.name + ", and I teach " + this.subject);
    //     }
    // }



    /* Interfaces

    // `FoodConsumer` interface
    public interface FoodConsumer
    {
        string eat();
    }

    // `Animal` interface
    public interface Animal
    {
        string sound();
    }
    public interface Shape
    {
        double area();
    }
    public class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double area()
        {
            // area = 3.14 * radius * radius
            return 3.14 * radius * radius;
        }
    }
    public class Square : Shape
    {
        double length;
        // overloaded constructor
        public Square(double length)
        {
            this.length = length;
        }
        // interface method
        public double area()
        {
            // area = length * length
            return length * length;
        }
    }
    // base class `Mammal` - one method `greet()`
    public class Mammal
    {
        private string name;

        public Mammal(string name)
        {
            this.name = name;
        }

        public string greet()
        {
            return "Hello, I'm " + this.name + ".";
        }
    }

    // `Dog` class inherits from `Mammal` class - inherits the `greet()` method
    // It implements both the `FoodConsumer` and `Animal` interfaces:
    //  - It implements the `FoodConsumer` interface's `eat()` method
    //  - It implements the `Animal` interface's `sound()` method
    public class Dog : Mammal, FoodConsumer, Animal
    {
        public Dog(string name) : base(name) { }

        public string eat()
        {
            return "Yum yum!";
        }

        public string sound()
        {
            return "Woof!";
        }
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            // double squareLength = 19.50;
            // Square sq = new Square(squareLength);
            // double area = sq.area();
            // Console.WriteLine(area);

            // double circleRadius = 4;
            // Circle cir = new Circle(circleRadius);
            // double circleArea = cir.area();
            // Console.WriteLine(circleArea);

            // Dog spot = new Dog("Spot");
            // Console.WriteLine(spot.greet());
            // Console.WriteLine(spot.eat());
            // Console.WriteLine(spot.sound());

            /*  Time Boys is the name, 35 is the age, and Math is the subject. */
            // Teacher teacher = new Teacher("Tim Boyd", 35, "Math");
            // teacher.sayHello();


            /* List */
            var animals = new ArrayList();
            animals.Add("bird");
            animals.Add("horse");
            animals.Add("dog");
            animals.Add("cat");
            // Iterate through the list.
            foreach (var animal in animals)
            {
                Console.WriteLine(animal + " ");
            }
        }
    }
}


/* Exercises */
/*
Task 1 of 2
Given the interface Area below, create a public Rectangle class that implements the interface. For the Rectangle class you will need:
Two double properties, height and width.
A constructor that accepts values for its two properties. The first parameter should be for height.

namespace Exercise {
    public interface Area {
        double GetArea();
    }
}

/* Answer */
/* 
using System;
namespace Exercise {
   public class Rectangle : Area
   {
       double height;
       double width;

       public Rectangle(double height, double width)
       {
           this.height = height;
           this.width = width;
       }
       public double GetArea()
       {
           return height * width;
       }
   }
}
*/


/*
Task 2 of 2
Given the interface Drawable below, create a public Deck class that implements the interface. For the Deck class you will need:

A property that is a List of strings. This collection will represent the playing cards of the deck. Use whatever variable name you'd like.

A constructor with a single parameter for setting the list of cards.

In the Drawable interface below, the GetTopCard method expects the implementation to get the first item. You can use the First() method of the List object to get the first item in the list: e.g. myList.First().

namespace Exercise {
    public interface Drawable {
        string GetTopCard();
    }
}
 */

/* Answer
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise {
    public class Deck: Drawable {
        public List<string> cards;

        public Deck(List<string> c) {
            this.cards = c;
        }

        public string GetTopCard() {
            return this.cards.First();
        }
    }
} */
