using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap08_Ex09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label ROTULO1 = new Label();
            Label ROTULO2 = new Label();
            Label ROTULO3 = new Label();
            Button BOTAO1 = new Button();
            Button BOTAO2 = new Button();
            int I, POSICAO;

            this.Text = "Média Escolar - Variável Indexada";
            this.Width = 329;
            this.Height = 300;

            ROTULO1.Text = "Entre com as oito médias escolares:";
            ROTULO1.SetBounds(12, 19, 176, 13);
            this.Controls.Add(ROTULO1);

            ROTULO2.Text = "Média Geral:";
            ROTULO2.SetBounds(141, 234, 67, 13);
            this.Controls.Add(ROTULO2);

            ROTULO3.Name = "Label3";
            ROTULO3.Text = "Label3";
            ROTULO3.SetBounds(214, 234, 39, 13);
            this.Controls.Add(ROTULO3);

            POSICAO = 45;
            for (I = 1; I <= 8; ++I)
            {
                TextBox CAMPO = new TextBox();
                CAMPO.Name = "TextBox" + I.ToString();
                CAMPO.SetBounds(15, POSICAO, 60, 20);
                this.Controls.Add(CAMPO);
                POSICAO += 26;
            }

            BOTAO1.Text = "Processar";
            BOTAO1.SetBounds(133, 198, 73, 23);
            BOTAO1.Click += new System.EventHandler(Processar);
            this.Controls.Add(BOTAO1);

            BOTAO2.Text = "Limpar";
            BOTAO2.SetBounds(215, 198, 73, 23);
            BOTAO2.Click += new System.EventHandler(Limpar);
            this.Controls.Add(BOTAO2);
        }

        private void Processar(object sender, EventArgs e)
        {
            float SOMA, MEDIA, VALOR;
            int J;
            SOMA = 0;
            J = 0;
            foreach (Control CONTROLE in this.Controls)
            {
                if (CONTROLE is TextBox)
                {
                    VALOR = Convert.ToSingle(((TextBox)CONTROLE).Text);
                    SOMA += VALOR;
                    J += 1;
                }
                MEDIA = SOMA / 8;
                this.Controls["Label3"].Text = MEDIA.ToString();
            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            foreach (Control CONTROLE in this.Controls)
            {
                if (CONTROLE is TextBox)
                {
                    ((TextBox)CONTROLE).Text = "";
                }
                this.Controls["Label3"].Text = "Label3";
                this.Controls["TextBox1"].Focus();
            }
        }

    }
}
