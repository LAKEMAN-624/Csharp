using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(brush.DefaultColor.Red);
            Console.WriteLine(brush.DefaultColor.Green);
            Console.WriteLine(brush.DefaultColor.Blue);
        }
    }
    struct Color
    {
        public int Red;
        public int Green;
        public int Blue;
    }
    class brush
    {
        public static readonly Color DefaultColor = new Color() { Red = 0, Green = 0, Blue = 0 };
    }
}
