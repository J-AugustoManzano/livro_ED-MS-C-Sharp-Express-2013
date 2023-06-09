using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ex07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label ROTULO = new Label();
            ROTULO.Text = "Estudo Dirigido de C#";
            ROTULO.SetBounds(90, 115, 153, 25);
            this.Controls.Add(ROTULO);
        }
    }
}
