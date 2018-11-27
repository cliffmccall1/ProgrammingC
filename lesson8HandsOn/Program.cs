using System;

namespace lesson8HandsOn
{
    public interface Animal
    {
        string eat();
    }
    public interface Mammal : Animal
    {
        string speak();
        string run();
    }
    public class Dog : Mammal
    {
        string sound;

        public Dog(string sound)
        {
            this.sound = sound;
        }
        public string speak()
        {
            return "Bark";
        }
        public string run()
        {
            return "Dogs can run at a top speed of 45 mph!";
        }
        public string eat()
        {
            return "Dogs eat bones.";
        }
    }
    public class Cat : Mammal
    {
        string sound;

        public Cat(string sound)
        {
            this.sound = sound;
        }
        public string speak()
        {
            return "Meow";
        }
        public string run()
        {
            return "Cats can run at a top speed of 30 mph!";
        }
        public string eat()
        {
            return "Cats eat mice.";
        }
    }
    public class Cow : Mammal
    {
        string sound;

        public Cow(string sound)
        {
            this.sound = sound;
        }
        public string speak()
        {
            return "Moo";
        }
        public string run()
        {
            return "Cows can run at a top speed of 25 mph!";
        }
        public string eat()
        {
            return "Cows eat grass.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Dog");
            Console.WriteLine(dog.speak());
            Console.WriteLine(dog.run());
            Console.WriteLine(dog.eat());


            Cat cat = new Cat("Cat");
            Console.WriteLine(cat.speak());
            Console.WriteLine(cat.run());
            Console.WriteLine(cat.eat());

            Cow cow = new Cow("Cow");
            Console.WriteLine(cow.speak());
            Console.WriteLine(cow.run());
            Console.WriteLine(cow.eat());

        }
    }
}
