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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            FrmCalculadoraIMC CalculoIMC = new FrmCalculadoraIMC(); // Instanciando um objeto em C#
            CalculoIMC.ShowDialog(); // O formulário de Cálculo de IMC será exibido através do método Dialog()

        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            FrmCalculoTabuadas Tabuadas = new FrmCalculoTabuadas();
            Tabuadas.ShowDialog();
        }
    }
}
