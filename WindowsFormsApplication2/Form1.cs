using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Berat
        {
            private int a, b;

            public Berat(int a, int b)
            { 
            this.a =a;
            this.b = b;
            }

            public int topla() {
                return this.a + this.b;
            } 

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Berat BeratClass = new Berat(10, 20);
            MessageBox.Show(BeratClass.topla().ToString());
        }
    }
}
