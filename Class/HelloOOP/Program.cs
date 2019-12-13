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
            //Car car = new Car();
            //Console.WriteLine(car is Vehicle);
            //Vehicle ve = new Vehicle();
            //Console.WriteLine(ve is Car);
            ////父类的变量可以引用子类的实例 is a
            //object o1 = new Vehicle();
            //RaceCar raceCar = new RaceCar();
            //raceCar.GetType
            Car car = new Car("Timothy");
            Console.WriteLine(car.Owner);
            car.ShowOwner();
        }
    }
    class Vehicle
    {
        public Vehicle(string owner)
        {
            this.Owner = owner;
        }
        public string Owner { get; set; }
    }
    class Car : Vehicle
    {
        public Car(string owner):base(owner) //父类的构造器是不能被继承的
        {
           
        }
        public void ShowOwner()
        {
            Console.WriteLine(base.Owner);
        }
    }
  
}
