using System;

namespace TelegramBot
{
    public static class Program
    {
        public static void Main()
        {
            Vehicle transport = new Truck();
            Console.ReadKey();
        }
    }

    public class Vehicle
    {
        protected Vehicle()
        {
            Console.WriteLine("Vehicle created");
        }
    }

    public class Car : Vehicle
    {
        protected Car()
        {
            Console.WriteLine("Car created");
        }
    }

    public class Truck : Car
    {
        public Truck()
        {
            Console.WriteLine("Truck created");
        }
    }
}