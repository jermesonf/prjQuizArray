namespace prjQuizSorteio
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
            this.rdoVal1 = new System.Windows.Forms.RadioButton();
            this.rdoVal2 = new System.Windows.Forms.RadioButton();
            this.rdoVal3 = new System.Windows.Forms.RadioButton();
            this.rdoVal4 = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoVal1
            // 
            this.rdoVal1.AutoSize = true;
            this.rdoVal1.Location = new System.Drawing.Point(14, 111);
            this.rdoVal1.Margin = new System.Windows.Forms.Padding(5);
            this.rdoVal1.Name = "rdoVal1";
            this.rdoVal1.Size = new System.Drawing.Size(48, 26);
            this.rdoVal1.TabIndex = 0;
            this.rdoVal1.TabStop = true;
            this.rdoVal1.Text = "Um";
            this.rdoVal1.UseVisualStyleBackColor = true;
            // 
            // rdoVal2
            // 
            this.rdoVal2.AutoSize = true;
            this.rdoVal2.Location = new System.Drawing.Point(14, 152);
            this.rdoVal2.Margin = new System.Windows.Forms.Padding(5);
            this.rdoVal2.Name = "rdoVal2";
            this.rdoVal2.Size = new System.Drawing.Size(68, 26);
            this.rdoVal2.TabIndex = 1;
            this.rdoVal2.TabStop = true;
            this.rdoVal2.Text = "Dois";
            this.rdoVal2.UseVisualStyleBackColor = true;
            // 
            // rdoVal3
            // 
            this.rdoVal3.AutoSize = true;
            this.rdoVal3.Location = new System.Drawing.Point(14, 192);
            this.rdoVal3.Margin = new System.Windows.Forms.Padding(5);
            this.rdoVal3.Name = "rdoVal3";
            this.rdoVal3.Size = new System.Drawing.Size(68, 26);
            this.rdoVal3.TabIndex = 2;
            this.rdoVal3.TabStop = true;
            this.rdoVal3.Text = "Tres";
            this.rdoVal3.UseVisualStyleBackColor = true;
            // 
            // rdoVal4
            // 
            this.rdoVal4.AutoSize = true;
            this.rdoVal4.Location = new System.Drawing.Point(14, 233);
            this.rdoVal4.Margin = new System.Windows.Forms.Padding(5);
            this.rdoVal4.Name = "rdoVal4";
            this.rdoVal4.Size = new System.Drawing.Size(88, 26);
            this.rdoVal4.TabIndex = 3;
            this.rdoVal4.TabStop = true;
            this.rdoVal4.Text = "Quatro";
            this.rdoVal4.UseVisualStyleBackColor = true;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(14, 48);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(190, 22);
            this.lblPergunta.TabIndex = 4;
            this.lblPergunta.Text = "Tradução de \"One\"?";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(170, 287);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(5);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(125, 39);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 347);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.rdoVal4);
            this.Controls.Add(this.rdoVal3);
            this.Controls.Add(this.rdoVal2);
            this.Controls.Add(this.rdoVal1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoVal1;
        private System.Windows.Forms.RadioButton rdoVal2;
        private System.Windows.Forms.RadioButton rdoVal3;
        private System.Windows.Forms.RadioButton rdoVal4;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Button btnResultado;
    }
}

