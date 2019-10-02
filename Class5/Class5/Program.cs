using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator c = new Calculator();
          //  int x = c.Add(1, 14);
            //Console.WriteLine(x);
           Calculator d = new Calculator();
            //string y = d.GetToday();
            //Console.WriteLine(y);
            d.PrintSum(1, 3);
        }
        class Calculator
        {
            public int Add(int a, int b)
            {
                int result = a + b;
                return result;
            }
            public string GetToday()
            {
                int day = DateTime.Now.Day;
                return day.ToString();
            }
            public void PrintSum(int a, int b)
            {
                int result = a + b;
                Console.WriteLine(result);
            }
        }
    }
}
