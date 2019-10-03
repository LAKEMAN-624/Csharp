using System;
namespace Class5_hannuota
{
    class Program
    {
        static void Main(string[] args)
        {
            Trans c = new Trans();
            double  result = c.Move(64);
            Console.WriteLine(result);
            double standard = Math.Pow(2, 64);
            Console.WriteLine(standard-1);
        }
    }
    class Trans
    {
        public double Move(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                double result = 2 * Move(x - 1) + 1;
                return result;
            }
        }
    }
}
