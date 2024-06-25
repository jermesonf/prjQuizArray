namespace prjQuizSorteio
{
    partial class Form2
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
            this.btnResultado.Location = new System.Drawing.Point(584, 280);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(5);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(125, 39);
            this.btnResultado.TabIndex = 11;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(17, 31);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(190, 22);
            this.lblPergunta.TabIndex = 10;
            this.lblPergunta.Text = "Tradução de \"One\"?";
            // 
            // rdoVal4
            // 
            this.rdoVal4.AutoSize = true;
            this.rdoVal4.Location = new System.Drawing.Point(17, 216);
            this.rdoVal4.Margin = new System.Windows.Forms.Padding(5);
            this.rdoVal4.Name = "rdoVal4";
            this.rdoVal4.Size = new System.Drawing.Size(88, 26);
            this.rdoVal4.TabIndex = 9;
            this.rdoVal4.TabStop = true;
            this.rdoVal4.Text = "Quatro";
            this.rdoVal4.UseVisualStyleBackColor = true;
            // 
            // rdoVal3
            // 
            this.rdoVal3.AutoSize = true;
            this.rdoVal3.Location = new System.Drawing.Point(17, 175);
            this.rdoVal3.Margin = new System.Windows.Forms.Padding(5);
            this.rdoVal3.Name = "rdoVal3";
            this.rdoVal3.Size = new System.Drawing.Size(68, 26);
            this.rdoVal3.TabIndex = 8;
            this.rdoVal3.TabStop = true;
            this.rdoVal3.Text = "Tres";
            this.rdoVal3.UseVisualStyleBackColor = true;
            // 
            // rdoVal2
            // 
            this.rdoVal2.AutoSize = true;
            this.rdoVal2.Location = new System.Drawing.Point(17, 135);
            this.rdoVal2.Margin = new System.Windows.Forms.Padding(5);
            this.rdoVal2.Name = "rdoVal2";
            this.rdoVal2.Size = new System.Drawing.Size(68, 26);
            this.rdoVal2.TabIndex = 7;
            this.rdoVal2.TabStop = true;
            this.rdoVal2.Text = "Dois";
            this.rdoVal2.UseVisualStyleBackColor = true;
            // 
            // rdoVal1
            // 
            this.rdoVal1.AutoSize = true;
            this.rdoVal1.Location = new System.Drawing.Point(17, 94);
            this.rdoVal1.Margin = new System.Windows.Forms.Padding(5);
            this.rdoVal1.Name = "rdoVal1";
            this.rdoVal1.Size = new System.Drawing.Size(48, 26);
            this.rdoVal1.TabIndex = 6;
            this.rdoVal1.TabStop = true;
            this.rdoVal1.Text = "Um";
            this.rdoVal1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 343);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.rdoVal4);
            this.Controls.Add(this.rdoVal3);
            this.Controls.Add(this.rdoVal2);
            this.Controls.Add(this.rdoVal1);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 2";
            this.Load += new System.EventHandler(this.Form2_Load);
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