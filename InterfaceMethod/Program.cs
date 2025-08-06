using System;

namespace InterfaceMethod
{
    // Define interface
    interface IMovable
    {
        void Move();
    }

    // Implement interface in Car class
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Implement interface in Bicycle class
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create IMovable references to Car and Bicycle
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            // Call Move() method
            myCar.Move();       // Output: Car is moving
            myBicycle.Move();   // Output: Bicycle is moving

            Console.ReadLine(); // Keep console open
        }
    }
}
