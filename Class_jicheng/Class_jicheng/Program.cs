using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type t = typeof(Car);
            //Type tb = t.BaseType;
            //Type tbb = tb.BaseType;
            //Console.WriteLine(tb.FullName);
            //Console.WriteLine(tbb.FullName);
            //Console.WriteLine(tbb.BaseType==null);

            //是一个 is a
            //Car car = new Car();
            //Console.WriteLine(car is Vehicle);
            //Vehicle ca1 = new Car();

            //RaceCar raceCar = new RaceCar();
            //子类对父类成员全盘继承
            //raceCar.Owner;
            //raceCar.GetType();

            Car car = new Car();
            Console.WriteLine(car.Owner);
            car.ShowOwner();
            Vehicle vehicle = new Vehicle();
            Console.WriteLine(vehicle.Owner); 
        }
    }
    class Vehicle
    {
        public Vehicle()
        {
            this.Owner = "N/A";
        }
        public string Owner { get; set; }
    }
    class Car:Vehicle
    {
        public Car()
        {
            this.Owner = "Car Owner";
        }
        public void ShowOwner()
        {
            Console.WriteLine(base.Owner);
        }
    }
    
    class RaceCar:Car
    {

    }
}
