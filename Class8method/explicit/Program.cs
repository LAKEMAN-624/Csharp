using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Stone stone = new Stone();
            stone.Age = 5000;
            Monkey sun = (Monkey)stone;
            Console.WriteLine(sun.Age);
        }
    }
    class Monkey
    {
        public int Age;
    }
    class Stone
    {
        public int Age;
        public static implicit operator Monkey(Stone stone)
        {
            Monkey m = new Monkey();
            m.Age = stone.Age / 500;
            return m;
        }
    }
}
