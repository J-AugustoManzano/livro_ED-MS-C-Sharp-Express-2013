using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ex06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float R = 0, A, B;
            A = float.Parse(textBox1.Text);
            B = float.Parse(textBox2.Text);
            if (radioButton1.Checked)
                R = A + B;
            if (radioButton2.Checked)
                R = A - B;
            if (radioButton3.Checked)
                R = A * B;
            if (radioButton4.Checked)
                if (B == 0)
                    MessageBox.Show("ERRO – Divisão zero!");
                else
                    R = A / B;
            textBox3.Text = R.ToString();
            textBox1.Focus();
        }
    }
}
