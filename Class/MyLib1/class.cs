using System;

namespace MyLib1
{
   public class Vehicle
    {
        //public string Owner { get; set; }
        protected int _rpm;
        private int _fuel;

        public void Refuel()
        {
            _fuel = 100;
        }

        protected void Burn(int fuel)
        {
            _fuel-=fuel;
        }

        public void Accelerate()
        {
            _rpm += 1000;
            Burn(1);
        }

        public int Speed { get { return _rpm / 100; } }
      
        public void RemainFuel()
        {
            Console.WriteLine("The remaining fuel is {0}",_fuel);
        }
    }
    public class Car: Vehicle
    {
        public void TurboAccelerate()
        {
            Burn(2);           
            _rpm += 3000;
        }

    }
}
