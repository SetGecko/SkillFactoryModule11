using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public static class Program
    {
        public static void Main()
        {
            Vehicle transport = new Truck(); // реально создали объект Truck, но забыли переопределить метод Move в Truck
            transport.Move();
            Console.ReadKey();
        }
    }

    public class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Moving");
        }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car moving");
        }
    }

    public class Truck : Car
    {
        public void Move() // забыли переопределить метод Move
        {
            Console.WriteLine("Truck moving");
        }
    }
}
