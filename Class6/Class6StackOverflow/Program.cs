using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int* p = stackalloc int[9999999];
            } 
            //BadGuy bg = new BadGuy();
            //bg.BadMethod()
        }
    }
    //class BadGuy
    //{
    //    public void BadMethod()
    //    {
    //        int x = 100;
    //        this.BadMethod();
    //    }
    //}
}
