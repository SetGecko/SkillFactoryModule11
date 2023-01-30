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

            //Vehicle transport = new Truck(); // реально создали объект Truck, но забыли переопределить метод Move в Truck

            //Варианты вызова метода new Truck().Move()
            //Truck transport = new Truck(); // явно объявить класс Truck
            //transport.Move();
            var transport = new Truck(); // var transport 
            transport.Move();
            ((Truck)transport).Move(); //Привести объект transport к типу Truck
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
        public override void Move() // забыли переопределить метод Move
        {
            Console.WriteLine("Truck moving");
        }
    }
}
