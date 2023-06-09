using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int R, X, A, B;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            X = A + B;
            if (X >= 10)
            {
                R = X + 5;
                MessageBox.Show("R = " + R.ToString(), "Resultado V");
            }
            else
            {
                R = X - 7;
                MessageBox.Show("R = " + R.ToString(), "Resultado F");
            }
            textBox1.Focus();
        }
    }
}
