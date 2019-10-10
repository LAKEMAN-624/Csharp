using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Context;
namespace Class6Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            
            Console.WriteLine(myType.BaseType.FullName);
        }
    }
}
