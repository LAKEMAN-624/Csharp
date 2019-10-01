using System;
using Tools;

namespace HelloWorld1001
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Calculator.Div(1,0);
            Console.WriteLine(result);
        }
    }
}
