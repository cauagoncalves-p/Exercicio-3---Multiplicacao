namespace Exercicio_3
{
    partial class Form1
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
            this.txtNumReal = new System.Windows.Forms.TextBox();
            this.txtNumInteiro = new System.Windows.Forms.TextBox();
            this.lblNumReal = new System.Windows.Forms.Label();
            this.lblNmero1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumReal
            // 
            this.txtNumReal.Location = new System.Drawing.Point(90, 93);
            this.txtNumReal.MaxLength = 100;
            this.txtNumReal.Multiline = true;
            this.txtNumReal.Name = "txtNumReal";
            this.txtNumReal.Size = new System.Drawing.Size(142, 28);
            this.txtNumReal.TabIndex = 9;
            // 
            // txtNumInteiro
            // 
            this.txtNumInteiro.Location = new System.Drawing.Point(90, 31);
            this.txtNumInteiro.MaxLength = 100;
            this.txtNumInteiro.Multiline = true;
            this.txtNumInteiro.Name = "txtNumInteiro";
            this.txtNumInteiro.Size = new System.Drawing.Size(142, 28);
            this.txtNumInteiro.TabIndex = 8;
            // 
            // lblNumReal
            // 
            this.lblNumReal.AutoSize = true;
            this.lblNumReal.Location = new System.Drawing.Point(16, 101);
            this.lblNumReal.Name = "lblNumReal";
            this.lblNumReal.Size = new System.Drawing.Size(53, 13);
            this.lblNumReal.TabIndex = 7;
            this.lblNumReal.Text = "Numero 2";
            // 
            // lblNmero1
            // 
            this.lblNmero1.AutoSize = true;
            this.lblNmero1.Location = new System.Drawing.Point(13, 39);
            this.lblNmero1.Name = "lblNmero1";
            this.lblNmero1.Size = new System.Drawing.Size(56, 13);
            this.lblNmero1.TabIndex = 6;
            this.lblNmero1.Text = "Numero  1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Multiplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 216);
            this.Controls.Add(this.txtNumReal);
            this.Controls.Add(this.txtNumInteiro);
            this.Controls.Add(this.lblNumReal);
            this.Controls.Add(this.lblNmero1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Multiplicação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumReal;
        private System.Windows.Forms.TextBox txtNumInteiro;
        private System.Windows.Forms.Label lblNumReal;
        private System.Windows.Forms.Label lblNmero1;
        private System.Windows.Forms.Button button1;
    }
}

