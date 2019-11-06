using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNameSpace;
namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            double res = cal.Add(1, 1);
            Console.WriteLine(res);
        }
    }
}
