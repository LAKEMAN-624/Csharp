using System;

namespace MyLib
{
    public class Vehicle
    {
        //internal string Owner { get; set; }
        private string Owner { get; set; }
    }
    class Car: Vehicle
    {
        public void ShowOwner()
        {
            //internal 同一个项目的其他类可以访问
            Console.WriteLine(base.Owner);
        }
    }
    public class C
    {

    }
}
