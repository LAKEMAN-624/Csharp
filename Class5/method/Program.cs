using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int result = c.SumAll(100);
            Console.WriteLine(result);
        }
    }
    class Calculator
    {

        //public int printxto1(int x)       
        //{
        //int s = 0;
        //    for (int i = x; i > 0; i--)
        //    {
        //        s = s + i;
        //    }
        //    return s;
        //}


        public int SumAll(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                int result = x + SumAll(x - 1);
                return result;
            }
        }
    }
}
