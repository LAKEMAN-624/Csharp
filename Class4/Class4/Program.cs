using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classandinstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Form myForm1;
            Form myForm2;
            myForm1 = new Form();
            myForm2 = myForm1;
            myForm1.Text = "My Form!";
            myForm2.Text = "Change!";
            myForm1.ShowDialog();
            myForm2.ShowDialog();
        }
    }
}
