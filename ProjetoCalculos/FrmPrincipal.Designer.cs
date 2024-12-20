namespace ProjetoCalculos
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.labelTituloFormPrincipal = new System.Windows.Forms.Label();
            this.btnCalcularIMC = new System.Windows.Forms.Button();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloFormPrincipal
            // 
            this.labelTituloFormPrincipal.AutoSize = true;
            this.labelTituloFormPrincipal.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloFormPrincipal.Location = new System.Drawing.Point(139, 94);
            this.labelTituloFormPrincipal.Name = "labelTituloFormPrincipal";
            this.labelTituloFormPrincipal.Size = new System.Drawing.Size(881, 45);
            this.labelTituloFormPrincipal.TabIndex = 0;
            this.labelTituloFormPrincipal.Text = "Sistema de Cálculos para Tornar Nosso dia Mais Simples.";
            // 
            // btnCalcularIMC
            // 
            this.btnCalcularIMC.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularIMC.Location = new System.Drawing.Point(240, 248);
            this.btnCalcularIMC.Name = "btnCalcularIMC";
            this.btnCalcularIMC.Size = new System.Drawing.Size(271, 119);
            this.btnCalcularIMC.TabIndex = 1;
            this.btnCalcularIMC.Text = "Cálculo de IMC \r\n(Índice de Massa Corporal)";
            this.btnCalcularIMC.UseVisualStyleBackColor = true;
            this.btnCalcularIMC.Click += new System.EventHandler(this.btnCalcularIMC_Click);
            // 
            // btnTabuada
            // 
            this.btnTabuada.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabuada.Location = new System.Drawing.Point(523, 248);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(213, 119);
            this.btnTabuada.TabIndex = 2;
            this.btnTabuada.Text = "Calcular Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 727);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.btnCalcularIMC);
            this.Controls.Add(this.labelTituloFormPrincipal);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto de Cálculos com Funcionalidades para Auxílio em Nosso Contidiano.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloFormPrincipal;
        private System.Windows.Forms.Button btnCalcularIMC;
        private System.Windows.Forms.Button btnTabuada;
    }
}

