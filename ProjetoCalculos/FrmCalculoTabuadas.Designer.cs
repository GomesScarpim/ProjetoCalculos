namespace ProjetoCalculos
{
    partial class FrmCalculoTabuadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculoTabuadas));
            this.lblFrmTituloTabuadas = new System.Windows.Forms.Label();
            this.lblInformacaoNumeroTabuada = new System.Windows.Forms.Label();
            this.textBoxEntradaValorTabuada = new System.Windows.Forms.TextBox();
            this.btnCalcularTabuada = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultadoTabuada = new System.Windows.Forms.Label();
            this.lblMensagemTabuada = new System.Windows.Forms.Label();
            this.pictureBoxImagemTabuada1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemTabuada1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrmTituloTabuadas
            // 
            this.lblFrmTituloTabuadas.AutoSize = true;
            this.lblFrmTituloTabuadas.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmTituloTabuadas.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblFrmTituloTabuadas.Location = new System.Drawing.Point(224, 85);
            this.lblFrmTituloTabuadas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrmTituloTabuadas.Name = "lblFrmTituloTabuadas";
            this.lblFrmTituloTabuadas.Size = new System.Drawing.Size(604, 86);
            this.lblFrmTituloTabuadas.TabIndex = 0;
            this.lblFrmTituloTabuadas.Text = "Bem Vindo ao Sistema de Tabuadas!\r\n  Vamos lhe ajudar nesse desafio!!!\r\n";
            // 
            // lblInformacaoNumeroTabuada
            // 
            this.lblInformacaoNumeroTabuada.AutoSize = true;
            this.lblInformacaoNumeroTabuada.BackColor = System.Drawing.Color.PowderBlue;
            this.lblInformacaoNumeroTabuada.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacaoNumeroTabuada.Location = new System.Drawing.Point(49, 229);
            this.lblInformacaoNumeroTabuada.Name = "lblInformacaoNumeroTabuada";
            this.lblInformacaoNumeroTabuada.Size = new System.Drawing.Size(586, 56);
            this.lblInformacaoNumeroTabuada.TabIndex = 1;
            this.lblInformacaoNumeroTabuada.Text = "Informe o Número da Tabuada, que você deseja o resultado. \r\nNo Campo Digite o Núm" +
    "ero:";
            // 
            // textBoxEntradaValorTabuada
            // 
            this.textBoxEntradaValorTabuada.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxEntradaValorTabuada.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEntradaValorTabuada.Location = new System.Drawing.Point(328, 261);
            this.textBoxEntradaValorTabuada.Name = "textBoxEntradaValorTabuada";
            this.textBoxEntradaValorTabuada.Size = new System.Drawing.Size(185, 36);
            this.textBoxEntradaValorTabuada.TabIndex = 2;
            this.textBoxEntradaValorTabuada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEntradaValorTabuada.TextChanged += new System.EventHandler(this.textBoxEntradaValorTabuada_TextChanged);
            // 
            // btnCalcularTabuada
            // 
            this.btnCalcularTabuada.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCalcularTabuada.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTabuada.Location = new System.Drawing.Point(419, 301);
            this.btnCalcularTabuada.Name = "btnCalcularTabuada";
            this.btnCalcularTabuada.Size = new System.Drawing.Size(94, 57);
            this.btnCalcularTabuada.TabIndex = 3;
            this.btnCalcularTabuada.Text = "Calcular \r\nTabuada";
            this.btnCalcularTabuada.UseVisualStyleBackColor = false;
            this.btnCalcularTabuada.Click += new System.EventHandler(this.btnCalcularTabuada_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpar.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(327, 301);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 57);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultadoTabuada
            // 
            this.lblResultadoTabuada.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTabuada.Location = new System.Drawing.Point(697, 296);
            this.lblResultadoTabuada.Name = "lblResultadoTabuada";
            this.lblResultadoTabuada.Size = new System.Drawing.Size(287, 334);
            this.lblResultadoTabuada.TabIndex = 5;
            this.lblResultadoTabuada.Click += new System.EventHandler(this.lblResultadoTabuada_Click);
            // 
            // lblMensagemTabuada
            // 
            this.lblMensagemTabuada.AutoSize = true;
            this.lblMensagemTabuada.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagemTabuada.Location = new System.Drawing.Point(555, 268);
            this.lblMensagemTabuada.Name = "lblMensagemTabuada";
            this.lblMensagemTabuada.Size = new System.Drawing.Size(0, 24);
            this.lblMensagemTabuada.TabIndex = 6;
            // 
            // pictureBoxImagemTabuada1
            // 
            this.pictureBoxImagemTabuada1.BackgroundImage = global::ProjetoCalculos.Properties.Resources.ícone_tabuada;
            this.pictureBoxImagemTabuada1.Location = new System.Drawing.Point(74, 386);
            this.pictureBoxImagemTabuada1.Name = "pictureBoxImagemTabuada1";
            this.pictureBoxImagemTabuada1.Size = new System.Drawing.Size(224, 244);
            this.pictureBoxImagemTabuada1.TabIndex = 7;
            this.pictureBoxImagemTabuada1.TabStop = false;
            // 
            // FrmCalculoTabuadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1107, 652);
            this.Controls.Add(this.pictureBoxImagemTabuada1);
            this.Controls.Add(this.lblMensagemTabuada);
            this.Controls.Add(this.lblResultadoTabuada);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcularTabuada);
            this.Controls.Add(this.textBoxEntradaValorTabuada);
            this.Controls.Add(this.lblInformacaoNumeroTabuada);
            this.Controls.Add(this.lblFrmTituloTabuadas);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmCalculoTabuadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Tabuadas";
            this.Load += new System.EventHandler(this.FrmCalculoTabuadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemTabuada1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrmTituloTabuadas;
        private System.Windows.Forms.Label lblInformacaoNumeroTabuada;
        private System.Windows.Forms.TextBox textBoxEntradaValorTabuada;
        private System.Windows.Forms.Button btnCalcularTabuada;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultadoTabuada;
        private System.Windows.Forms.Label lblMensagemTabuada;
        private System.Windows.Forms.PictureBox pictureBoxImagemTabuada1;
    }
}