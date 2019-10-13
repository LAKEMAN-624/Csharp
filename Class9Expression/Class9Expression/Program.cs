using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Class9Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 1, 2, 3 };
            double[] doubleArray = new double[] { 1.0, 2.0, 3.0 };
            //var x = intList[1];
            var x = doubleArray[1];
            Console.WriteLine(x.GetType());
        }
    }
}
