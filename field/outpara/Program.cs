using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outpara
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            bool b = DoubleParser.TryParse("ABC", out x);
            if(b==true)
            {
                Console.WriteLine(x + 1);
            }
            else
            {
                Console.WriteLine(x);
            }

        }
    }
    class DoubleParser
    {
        public static bool TryParse(string input,out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch 
            {
                result = 0;
                return false;
            }
        }
    }
}
