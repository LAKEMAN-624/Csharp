using System;
using MyLib;

namespace Classfangwen
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Owner = "fuc";
            Console.WriteLine(  vehicle.Owner);
        }
    }
}
