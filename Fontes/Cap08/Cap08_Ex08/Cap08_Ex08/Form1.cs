using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ex08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button BOTAO = new Button();
            BOTAO.Text = "Me Acione";
            BOTAO.SetBounds(84, 100, 120, 46);
            BOTAO.Click += new System.EventHandler(Apresenta);
            this.Controls.Add(BOTAO);
        }

        private void Apresenta(object sender, EventArgs e)
        {
            MessageBox.Show("Uau!!! Você me acionou.");
        } 

    }
}
