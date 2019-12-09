using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNameSpace;
using myfun.NewFolder;
namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiply mul = new Multiply();
            int a = mul.Multiplyint(2, 3);
            Console.WriteLine(a);
        }
    }
}
