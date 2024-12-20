namespace ProjetoCalculos
{
    partial class FrmCalculadoraIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadoraIMC));
            this.lblTituloFormCalcularIMC = new System.Windows.Forms.Label();
            this.lblAlturaFrmCalculoIMC = new System.Windows.Forms.Label();
            this.lblPesoFrmCalculoIMC = new System.Windows.Forms.Label();
            this.textBoxAlturaCalculoIMC = new System.Windows.Forms.TextBox();
            this.textBoxPesoCalculoIMC = new System.Windows.Forms.TextBox();
            this.lblResultadoCalculoIMC = new System.Windows.Forms.Label();
            this.lblTxtMensagem = new System.Windows.Forms.Label();
            this.lblExemploTxtBoxAltura = new System.Windows.Forms.Label();
            this.lblExemploTxtBoxPeso = new System.Windows.Forms.Label();
            this.btnCalcularIMC = new System.Windows.Forms.Button();
            this.btnLimparFormularioIMC = new System.Windows.Forms.Button();
            this.pictureBoxIMC2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIMC1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMC1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormCalcularIMC
            // 
            this.lblTituloFormCalcularIMC.AutoSize = true;
            this.lblTituloFormCalcularIMC.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormCalcularIMC.Location = new System.Drawing.Point(241, 85);
            this.lblTituloFormCalcularIMC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTituloFormCalcularIMC.Name = "lblTituloFormCalcularIMC";
            this.lblTituloFormCalcularIMC.Size = new System.Drawing.Size(842, 45);
            this.lblTituloFormCalcularIMC.TabIndex = 0;
            this.lblTituloFormCalcularIMC.Text = "Sistema de Cálculo de IMC (Índice de Massa Corporal)";
            // 
            // lblAlturaFrmCalculoIMC
            // 
            this.lblAlturaFrmCalculoIMC.AutoSize = true;
            this.lblAlturaFrmCalculoIMC.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlturaFrmCalculoIMC.Location = new System.Drawing.Point(395, 195);
            this.lblAlturaFrmCalculoIMC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAlturaFrmCalculoIMC.Name = "lblAlturaFrmCalculoIMC";
            this.lblAlturaFrmCalculoIMC.Size = new System.Drawing.Size(182, 24);
            this.lblAlturaFrmCalculoIMC.TabIndex = 1;
            this.lblAlturaFrmCalculoIMC.Text = "Informe a sua Altura";
            // 
            // lblPesoFrmCalculoIMC
            // 
            this.lblPesoFrmCalculoIMC.AutoSize = true;
            this.lblPesoFrmCalculoIMC.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoFrmCalculoIMC.Location = new System.Drawing.Point(395, 269);
            this.lblPesoFrmCalculoIMC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPesoFrmCalculoIMC.Name = "lblPesoFrmCalculoIMC";
            this.lblPesoFrmCalculoIMC.Size = new System.Drawing.Size(171, 24);
            this.lblPesoFrmCalculoIMC.TabIndex = 2;
            this.lblPesoFrmCalculoIMC.Text = "Informe o seu Peso";
            // 
            // textBoxAlturaCalculoIMC
            // 
            this.textBoxAlturaCalculoIMC.Location = new System.Drawing.Point(579, 194);
            this.textBoxAlturaCalculoIMC.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAlturaCalculoIMC.Name = "textBoxAlturaCalculoIMC";
            this.textBoxAlturaCalculoIMC.Size = new System.Drawing.Size(126, 31);
            this.textBoxAlturaCalculoIMC.TabIndex = 3;
            this.textBoxAlturaCalculoIMC.Text = " ";
            this.textBoxAlturaCalculoIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPesoCalculoIMC
            // 
            this.textBoxPesoCalculoIMC.Location = new System.Drawing.Point(578, 267);
            this.textBoxPesoCalculoIMC.Name = "textBoxPesoCalculoIMC";
            this.textBoxPesoCalculoIMC.Size = new System.Drawing.Size(127, 31);
            this.textBoxPesoCalculoIMC.TabIndex = 4;
            this.textBoxPesoCalculoIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResultadoCalculoIMC
            // 
            this.lblResultadoCalculoIMC.Location = new System.Drawing.Point(28, 336);
            this.lblResultadoCalculoIMC.Name = "lblResultadoCalculoIMC";
            this.lblResultadoCalculoIMC.Size = new System.Drawing.Size(1128, 175);
            this.lblResultadoCalculoIMC.TabIndex = 5;
            this.lblResultadoCalculoIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultadoCalculoIMC.UseWaitCursor = true;
            // 
            // lblTxtMensagem
            // 
            this.lblTxtMensagem.AutoSize = true;
            this.lblTxtMensagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtMensagem.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTxtMensagem.Location = new System.Drawing.Point(303, 336);
            this.lblTxtMensagem.Name = "lblTxtMensagem";
            this.lblTxtMensagem.Size = new System.Drawing.Size(0, 19);
            this.lblTxtMensagem.TabIndex = 6;
            // 
            // lblExemploTxtBoxAltura
            // 
            this.lblExemploTxtBoxAltura.AutoSize = true;
            this.lblExemploTxtBoxAltura.BackColor = System.Drawing.SystemColors.Control;
            this.lblExemploTxtBoxAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExemploTxtBoxAltura.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemploTxtBoxAltura.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblExemploTxtBoxAltura.Location = new System.Drawing.Point(583, 226);
            this.lblExemploTxtBoxAltura.Name = "lblExemploTxtBoxAltura";
            this.lblExemploTxtBoxAltura.Size = new System.Drawing.Size(121, 21);
            this.lblExemploTxtBoxAltura.TabIndex = 7;
            this.lblExemploTxtBoxAltura.Text = "(Exemplo: 1,78)";
            this.lblExemploTxtBoxAltura.Click += new System.EventHandler(this.lblExemploTxtBoxAltura_Click);
            // 
            // lblExemploTxtBoxPeso
            // 
            this.lblExemploTxtBoxPeso.AutoSize = true;
            this.lblExemploTxtBoxPeso.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemploTxtBoxPeso.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblExemploTxtBoxPeso.Location = new System.Drawing.Point(572, 301);
            this.lblExemploTxtBoxPeso.Name = "lblExemploTxtBoxPeso";
            this.lblExemploTxtBoxPeso.Size = new System.Drawing.Size(139, 21);
            this.lblExemploTxtBoxPeso.TabIndex = 8;
            this.lblExemploTxtBoxPeso.Text = "(Exemplo: 75,600)";
            this.lblExemploTxtBoxPeso.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalcularIMC
            // 
            this.btnCalcularIMC.BackColor = System.Drawing.Color.Cyan;
            this.btnCalcularIMC.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularIMC.Location = new System.Drawing.Point(595, 514);
            this.btnCalcularIMC.Name = "btnCalcularIMC";
            this.btnCalcularIMC.Size = new System.Drawing.Size(129, 50);
            this.btnCalcularIMC.TabIndex = 9;
            this.btnCalcularIMC.Text = "Calcular";
            this.btnCalcularIMC.UseVisualStyleBackColor = false;
            this.btnCalcularIMC.Click += new System.EventHandler(this.btnCalcularIMC_Click);
            // 
            // btnLimparFormularioIMC
            // 
            this.btnLimparFormularioIMC.BackColor = System.Drawing.Color.Gold;
            this.btnLimparFormularioIMC.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFormularioIMC.Location = new System.Drawing.Point(474, 514);
            this.btnLimparFormularioIMC.Name = "btnLimparFormularioIMC";
            this.btnLimparFormularioIMC.Size = new System.Drawing.Size(117, 49);
            this.btnLimparFormularioIMC.TabIndex = 10;
            this.btnLimparFormularioIMC.Text = "Limpar";
            this.btnLimparFormularioIMC.UseVisualStyleBackColor = false;
            this.btnLimparFormularioIMC.Click += new System.EventHandler(this.btnLimparFormularioIMC_Click);
            // 
            // pictureBoxIMC2
            // 
            this.pictureBoxIMC2.BackgroundImage = global::ProjetoCalculos.Properties.Resources.IMC_V00;
            this.pictureBoxIMC2.Location = new System.Drawing.Point(63, 20);
            this.pictureBoxIMC2.Name = "pictureBoxIMC2";
            this.pictureBoxIMC2.Size = new System.Drawing.Size(151, 149);
            this.pictureBoxIMC2.TabIndex = 12;
            this.pictureBoxIMC2.TabStop = false;
            // 
            // pictureBoxIMC1
            // 
            this.pictureBoxIMC1.BackgroundImage = global::ProjetoCalculos.Properties.Resources.IMC_V4;
            this.pictureBoxIMC1.Location = new System.Drawing.Point(785, 179);
            this.pictureBoxIMC1.Name = "pictureBoxIMC1";
            this.pictureBoxIMC1.Size = new System.Drawing.Size(150, 146);
            this.pictureBoxIMC1.TabIndex = 11;
            this.pictureBoxIMC1.TabStop = false;
            // 
            // FrmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1186, 645);
            this.Controls.Add(this.pictureBoxIMC2);
            this.Controls.Add(this.pictureBoxIMC1);
            this.Controls.Add(this.btnLimparFormularioIMC);
            this.Controls.Add(this.btnCalcularIMC);
            this.Controls.Add(this.lblExemploTxtBoxPeso);
            this.Controls.Add(this.lblExemploTxtBoxAltura);
            this.Controls.Add(this.lblTxtMensagem);
            this.Controls.Add(this.lblResultadoCalculoIMC);
            this.Controls.Add(this.textBoxPesoCalculoIMC);
            this.Controls.Add(this.textBoxAlturaCalculoIMC);
            this.Controls.Add(this.lblPesoFrmCalculoIMC);
            this.Controls.Add(this.lblAlturaFrmCalculoIMC);
            this.Controls.Add(this.lblTituloFormCalcularIMC);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmCalculadoraIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCalculadoraIMC_Load);
            this.Enter += new System.EventHandler(this.btnCalcularIMC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMC1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloFormCalcularIMC;
        private System.Windows.Forms.Label lblAlturaFrmCalculoIMC;
        private System.Windows.Forms.Label lblPesoFrmCalculoIMC;
        private System.Windows.Forms.TextBox textBoxAlturaCalculoIMC;
        private System.Windows.Forms.TextBox textBoxPesoCalculoIMC;
        private System.Windows.Forms.Label lblResultadoCalculoIMC;
        private System.Windows.Forms.Label lblTxtMensagem;
        private System.Windows.Forms.Label lblExemploTxtBoxAltura;
        private System.Windows.Forms.Label lblExemploTxtBoxPeso;
        private System.Windows.Forms.Button btnCalcularIMC;
        private System.Windows.Forms.Button btnLimparFormularioIMC;
        private System.Windows.Forms.PictureBox pictureBoxIMC1;
        private System.Windows.Forms.PictureBox pictureBoxIMC2;
    }
}