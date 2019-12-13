using System;
using MyLib1;

namespace HelloAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Refuel();
            Console.WriteLine(car.Speed);
            car.RemainFuel();
            car.Accelerate();
            Console.WriteLine(car.Speed);
            car.RemainFuel();
            car.TurboAccelerate();
            Console.WriteLine(car.Speed);
            car.RemainFuel();
            
        }
    }
}
