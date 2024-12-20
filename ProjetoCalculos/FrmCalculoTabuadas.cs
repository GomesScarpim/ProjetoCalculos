using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculos
{
    public partial class FrmCalculoTabuadas : Form
    {
        public FrmCalculoTabuadas()
        {
            InitializeComponent();
        }

        private void textBoxEntradaValorTabuada_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxEntradaValorTabuada.Text = "";
            lblResultadoTabuada.Text = "";
            lblMensagemTabuada.Text = "";
        }

        private void FrmCalculoTabuadas_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularTabuada_Click(object sender, EventArgs e)
        {
            if (textBoxEntradaValorTabuada.Text == "")
            {

                MessageBox.Show("Você precisa digitar algum número, para que assim seja possível calcular uma tabuada! Clique em OK, e informe um número.", "Informação", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
            else
            {
                float numeroCalculoTabuada, resultadoTabuada;
                numeroCalculoTabuada = float.Parse(textBoxEntradaValorTabuada.Text);

                lblMensagemTabuada.Text = "Resposta da sua Tabuada Solicitada do número: "+ numeroCalculoTabuada;
                for (int i=0; i<=10; i++)
                {
                    resultadoTabuada = numeroCalculoTabuada * i;
                   
                    lblResultadoTabuada.Text += numeroCalculoTabuada + " x " + i + " = " + resultadoTabuada +"\r\n";
                }
               

                
            }
        }

        private void lblResultadoTabuada_Click(object sender, EventArgs e)
        {

        }
    }
}