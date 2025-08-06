using System;

namespace InheritanceMethod
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            // Call MakeSound() on each
            genericAnimal.MakeSound();  // Output: Some generic sound
            dog.MakeSound();            // Output: Bark
            cat.MakeSound();            // Output: Meow

            Console.ReadLine(); // To keep the console window open
        }
    }
}
