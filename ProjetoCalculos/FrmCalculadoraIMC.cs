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
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void lblExemploTxtBoxAltura_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o campo de altura está vazio ou inválido.
                if (string.IsNullOrWhiteSpace(textBoxAlturaCalculoIMC.Text))
                {
                    MessageBox.Show("Favor entrar com dados Validos Exemplo: 1,76 (Altura) e (Peso) 85,300. Só Assim iremos conseguir efetuar o Cálculo.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxAlturaCalculoIMC.Focus(); // Foca no campo de altura.
                    return;
                }

                // Verifica se o campo de peso está vazio ou inválido.
                if (string.IsNullOrWhiteSpace(textBoxPesoCalculoIMC.Text))
                {
                    MessageBox.Show("Favor verificar os dados, deve entrar com dados válidos!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPesoCalculoIMC.Focus(); // Foca no campo de peso.
                    return;
                }

                // Verifica se altura é um valor numérico válido.
                if (!float.TryParse(textBoxAlturaCalculoIMC.Text, out float altura) || altura <= 0)
                {
                    MessageBox.Show("A altura deve ser um número maior que zero.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxAlturaCalculoIMC.Focus();
                    return;
                }

                // Verifica se peso é um valor numérico válido.
                if (!float.TryParse(textBoxPesoCalculoIMC.Text, out float peso) || peso <= 0)
                {
                    MessageBox.Show("O peso deve ser um número maior que zero.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPesoCalculoIMC.Focus();
                    return;
                }





                // Calcula o IMC.
                float resultado_IMC = peso / (altura * altura);

                // Exibe a mensagem correspondente ao valor do IMC calculado.
                if (resultado_IMC < 16)
                {

                    lblTxtMensagem.Text = "Mensagem";
                    lblResultadoCalculoIMC.Text = "O seu resultado do IMC é: " + resultado_IMC + "\r\n " +
                   "\rBaixo peso severo, Grave (Magreza): IMC abaixo de 16,0, indicando risco aumentado de complicações" +
                   "de saúde graves. Essas faixas de IMC auxiliam profissionais de saúde a avaliar o risco de condições" +
                   "associadas,como deficiências nutricionais e aumento da vulnerabilidade a infecções. O controle e" +
                   "monitoramento da obesidade e condições associadas ao baixo peso Você pode conferir essas informações" +
                   "detalhadas no portal da OMS: https://www.who.int/data/gho/data/themes/topics/topic-details/GHO/body-mass-index";
                    lblResultadoCalculoIMC.ForeColor = Color.DarkRed;
                }
                else if (resultado_IMC >= 16 && resultado_IMC <= 16.9)
                {
                    lblTxtMensagem.Text = "Mensagem";
                    lblResultadoCalculoIMC.Text = "O seu resultado do IMC é: " + resultado_IMC + "\r\n" +
                       "\rIMC abaixo de 16 e 16.9. Você, está no Baixo peso moderado CUIDADO!";
                    lblResultadoCalculoIMC.ForeColor = Color.DarkRed;
                }
                else if (resultado_IMC >= 17 && resultado_IMC <= 18.4)
                {
                    lblTxtMensagem.Text = "Mensagem";
                    lblResultadoCalculoIMC.Text = "O seu resultado do IMC é: " + resultado_IMC + "\r\n" +
                        "\rIMC Acima de 17 e Menor que 18.4. A Organização Mundial da Saúde (OMS)." +
                        "\rClassifica o Índice de Massa Corporal (IMC) abaixo de 18,5, como: 'Baixo Peso' ou 'Magreza.'";
                    lblResultadoCalculoIMC.ForeColor = Color.DarkMagenta;
                }
                else if (resultado_IMC >= 18.50 && resultado_IMC <= 24.9)
                {
                    lblTxtMensagem.Text = "Mensagem";
                    lblResultadoCalculoIMC.Text = "O seu resultado do IMC é: " + resultado_IMC + "\r\n" +
                        "\rIMC Entre 18,50 e 24,99, você está com peso Normal!" +
                        "\rContinue Assim!!!";
                    lblResultadoCalculoIMC.ForeColor = Color.DarkBlue;
                }
                else if (resultado_IMC >= 25 && resultado_IMC <= 29.99)
                {
                    lblTxtMensagem.Text = "Mensagem";
                    lblResultadoCalculoIMC.Text = "O seu resultado do IMC é: " + resultado_IMC + "\r\n" +
                        "\rIMC Entre 25 e 29.99, ATENÇÃO! Você está no SOBRE PESO!" +
                        "\rAcima do peso entre os adultos! Cuidado!";
                    lblResultadoCalculoIMC.ForeColor = Color.DarkViolet;
                }
                else if (resultado_IMC >= 30 && resultado_IMC <= 34.99)
                {
                    lblTxtMensagem.Text = "Mensagem";

                    lblResultadoCalculoIMC.Text = "O seu resultado do IMC é: " + resultado_IMC + "\r\n"
                       + "\rIMC Entre 30 e 34,99. ATENÇÃO! Obesidade Classe I! " +
                       "\rCUIDADO! Procure Ajuda!!!";
                    lblResultadoCalculoIMC.ForeColor = Color.DarkRed;
                }
                else if (resultado_IMC >= 35 && resultado_IMC <= 39.99)
                {
                    lblTxtMensagem.Text = "Mensagem";
                    lblResultadoCalculoIMC.Text = "O seu resultado do IMC é: " + resultado_IMC + "\r\n"
                        + "\r\nIMC Entre 35 e 39,99. ATENÇÃO!!!" + "\rVocê está na Obesidade Classe II! CUIDADO! " +
                        "\rProcure Ajuda, o quanto antes!" +
                      "\rSite OMS: https://www.who.int/data/gho/data/themes/topics/topic-details/GHO/body-mass-index";
                    lblResultadoCalculoIMC.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblTxtMensagem.Text = "Mensagem";
                               lblResultadoCalculoIMC.Text = "O seu resultado do IMC é: " + resultado_IMC + "\r\n"
                        + "\r\nIMC Acima de 40, ATENÇÃO!!! É Obesidade classe III Mórbida (Severa)!!!" + "\n" +
                        "\r\nVocê está Com Risco de Vida! Procure Ajuda o Quanto Antes!!!" +
                        "\rSite OMS: https://www.who.int/data/gho/data/themes/topics/topic-details/GHO/body-mass-index";
                    lblResultadoCalculoIMC.ForeColor = Color.DarkRed;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCalculadoraIMC_Load(object sender, EventArgs e)
        {

        }

        private void btnLimparFormularioIMC_Click(object sender, EventArgs e)
        {
            textBoxAlturaCalculoIMC.Text = "";
            textBoxPesoCalculoIMC.Text = "";
            lblResultadoCalculoIMC.Text = "";
            lblTxtMensagem.Text = "";

        }
    }
}
        