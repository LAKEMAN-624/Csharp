using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refpara
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            IWandSideEffect(ref y);
            Console.WriteLine(y);
        }
        static void IWandSideEffect(ref int x)
        {
            x = x + 100;
        }
    }
}
