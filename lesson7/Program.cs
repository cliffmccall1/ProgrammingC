using System;

namespace lesson7
{
    // // Vehicle Class
    // public class Vehicle
    // {
    //     string make;
    //     string color;
    //     bool isRunning = false;
    //     int fuelLevel;

    //     public Vehicle(string make, string color, int fuelLevel)
    //     {
    //         this.make = make;
    //         this.color = color;
    //         this.isRunning = false;
    //         this.fuelLevel = fuelLevel;
    //     }
    //     public void printDetails()
    //     {
    //         Console.WriteLine("The " + this.color + " " + this.make + " has a fuel level of " + this.fuelLevel + ". Is it running? " + this.isRunning);
    //     }
    //     public static void printVehicleColor(Vehicle v)
    //     {
    //         string vehicleColor = v.color;
    //         Console.WriteLine(vehicleColor);
    //     }
    // }

    // // Car Class
    // public class Car : Vehicle
    // {
    //     int trunkWidth;

    //     public Car(string make, string color, int fuelLevel, int trunkWidth)
    //     : base(make, color, fuelLevel)
    //     {
    //         this.trunkWidth = trunkWidth;
    //     }
    // }
    // // Truck Class
    // public class Truck : Vehicle
    // {
    //     int flatbedLength;

    //     public Truck(string make, string color, int fuelLevel, int flatbedLength)
    //     : base(make, color, fuelLevel)
    //     {
    //         this.flatbedLength = flatbedLength;
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         // Vehicle newVehicle = new Vehicle("AcmeVehicle", "Gray", 5);
    //         // newVehicle.printDetails();

    //         // Car newCar = new Car("AcmeCar", "Black", 15, 10);
    //         // newCar.printDetails();

    //         // Truck newTruck = new Truck("AcmeTruck", "White", 25, 20);
    //         // newTruck.printDetails();
    //         Vehicle newVehicle = new Vehicle("AcmeVehicle", "Gray", 5);
    //         Vehicle.printVehicleColor(newVehicle);

    //         Car newCar = new Car("AcmeCar", "Black", 15, 10);
    //         Vehicle.printVehicleColor(newCar);

    //         Truck newTruck = new Truck("AcmeTruck", "White", 25, 20);
    //         Vehicle.printVehicleColor(newTruck);

    //     }
    // }

    class MemberSupplies
    {
        public class Member
        {
            public string name;
            //baseSupplies is defined as protected so that it may be accessed only by this class and derived classes.
            protected double baseSupplies;

            //Constructor to set the name and baseSupplies values
            public Member(string name, double baseSupplies)
            {
                this.name = name;
                this.baseSupplies = baseSupplies;
            }
            // Declasred virtual so it can be overridden
            public virtual double CalculateSuppies()
            {
                return baseSupplies;
            }
        }
        // Derivce (inherit) a new class from Member.
        public class PremiumMember : Member
        {
            // New field that will affect the result of 'CalculateSupplies'
            private double premiumSupplies;
            // The constructor calls the base-class version and initializes the premiumSupplies field
            public PremiumMember(string name, double baseSupplies, double premiumSupplies)
            : base(name, baseSupplies)
            {
                this.premiumSupplies = premiumSupplies;

            }
            // Override the 'CalculateSupplies' method to tak premium into account
            public override double CalculateSuppies()
            {
                return baseSupplies + premiumSupplies;
            }
        }
        class Program
        {
            static void Main()
            {
                // create some new employees
                PremiumMember member1 = new PremiumMember("Alice", 11200, 500);
                Member member2 = new Member("Bob", 11200);

                Console.WriteLine("Premium Member: " + member1.name + " paid " + member1.CalculateSuppies());
                Console.WriteLine("Member: " + member2.name + " paid " + member2.CalculateSuppies());
            }
        }
    }
}


/*** Exercise 1 ***/
/*
Create two public classes: Mammal and Bird. Each should inherit from the Animal class shown below.
For each new class, override the GiveBirth method to produce the following output:
For the Mammal class, the method should return: "I give live birth"
For the Bird class, the method should return "I lay eggs"

namespace Exercise {
    public class Animal {
        public virtual string GiveBirth() {
            return "I don't know how";
        }
    }
}
*/
/* Answer */

// using System;
// namespace Exercise {
//     public class Mammal: Animal
//     {
//         public override string GiveBirth()
//         {
//         return "I give live birth";
//         }
//     }
//     public class Bird: Animal
//     {
//         public override string GiveBirth()
//         {
//         return "I lay eggs";
//         }
//     }
// }

/*** Exercise 2 ***/
/*
Given the Bird class below, construct the base class Animal from which it inherits.
For the Animal class, you will need:
A default constructor.
A constructor that accepts values for its two string properties: name and birthMethod.
A public method named GiveBirth (no parameters) that returns the value of the birthMethod property (a string).

namespace Exercise {
    public class Bird: Animal {
        bool flies;
        public Bird(): base() {
            this.flies = true;
        }
        public Bird(string name, bool flies)
            : base(name, "eggs")
        {
            this.flies = flies;
        }
    }
}
*/
/* Answer */
// using System;
// namespace Exercise {
//     public class Animal
//     {
//         public string name;
//         public string birthMethod;

//         public Animal()
//         {
//             this.name = "";
//             this.birthMethod = "";
//         }
//         public Animal(string name, string birthMethod)
//         {
//             this.name = name;
//             this.birthMethod = birthMethod;
//         }
//         public string GiveBirth()
//         {
//             return this.birthMethod;
//         }
//     }
// }