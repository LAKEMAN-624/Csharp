using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHelloWorld1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textshowhello_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonsayhello_Click(object sender, EventArgs e)
        {
            textshowhello.Text = "Hello World!";
        }
    }
}
