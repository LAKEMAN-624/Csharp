using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class8method
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            double Volume = c.GetConeVolume(5,5);
            Console.WriteLine(Volume);
        }
    }
    class Calculator
    {
        public double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }
        public double GetCylinderVolume(double r, double h)
        {
            return GetCircleArea(r) * h;
        }
        public double GetConeVolume(double r, double h)
        {
            return GetCylinderVolume(r, h) / 3;
        }
    }
}
