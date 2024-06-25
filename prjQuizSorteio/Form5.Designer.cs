namespace prjQuizSorteio
{
    partial class Form5
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
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.rdoVal4 = new System.Windows.Forms.RadioButton();
            this.rdoVal3 = new System.Windows.Forms.RadioButton();
            this.rdoVal2 = new System.Windows.Forms.RadioButton();
            this.rdoVal1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(373, 294);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(7);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(187, 57);
            this.btnResultado.TabIndex = 29;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(12, 23);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(171, 19);
            this.lblPergunta.TabIndex = 28;
            this.lblPergunta.Text = "Tradução de \"One\"?";
            // 
            // rdoVal4
            // 
            this.rdoVal4.AutoSize = true;
            this.rdoVal4.Location = new System.Drawing.Point(16, 193);
            this.rdoVal4.Margin = new System.Windows.Forms.Padding(7);
            this.rdoVal4.Name = "rdoVal4";
            this.rdoVal4.Size = new System.Drawing.Size(81, 23);
            this.rdoVal4.TabIndex = 27;
            this.rdoVal4.TabStop = true;
            this.rdoVal4.Text = "Quatro";
            this.rdoVal4.UseVisualStyleBackColor = true;
            // 
            // rdoVal3
            // 
            this.rdoVal3.AutoSize = true;
            this.rdoVal3.Location = new System.Drawing.Point(16, 156);
            this.rdoVal3.Margin = new System.Windows.Forms.Padding(7);
            this.rdoVal3.Name = "rdoVal3";
            this.rdoVal3.Size = new System.Drawing.Size(63, 23);
            this.rdoVal3.TabIndex = 26;
            this.rdoVal3.TabStop = true;
            this.rdoVal3.Text = "Tres";
            this.rdoVal3.UseVisualStyleBackColor = true;
            // 
            // rdoVal2
            // 
            this.rdoVal2.AutoSize = true;
            this.rdoVal2.Location = new System.Drawing.Point(16, 119);
            this.rdoVal2.Margin = new System.Windows.Forms.Padding(7);
            this.rdoVal2.Name = "rdoVal2";
            this.rdoVal2.Size = new System.Drawing.Size(63, 23);
            this.rdoVal2.TabIndex = 25;
            this.rdoVal2.TabStop = true;
            this.rdoVal2.Text = "Dois";
            this.rdoVal2.UseVisualStyleBackColor = true;
            // 
            // rdoVal1
            // 
            this.rdoVal1.AutoSize = true;
            this.rdoVal1.Location = new System.Drawing.Point(16, 82);
            this.rdoVal1.Margin = new System.Windows.Forms.Padding(7);
            this.rdoVal1.Name = "rdoVal1";
            this.rdoVal1.Size = new System.Drawing.Size(45, 23);
            this.rdoVal1.TabIndex = 24;
            this.rdoVal1.TabStop = true;
            this.rdoVal1.Text = "Um";
            this.rdoVal1.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 379);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.rdoVal4);
            this.Controls.Add(this.rdoVal3);
            this.Controls.Add(this.rdoVal2);
            this.Controls.Add(this.rdoVal1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RadioButton rdoVal4;
        private System.Windows.Forms.RadioButton rdoVal3;
        private System.Windows.Forms.RadioButton rdoVal2;
        private System.Windows.Forms.RadioButton rdoVal1;
    }
}