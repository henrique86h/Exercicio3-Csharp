namespace Exercicio3_Csharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxJucelia = new System.Windows.Forms.TextBox();
            this.txtBoxSophia = new System.Windows.Forms.TextBox();
            this.txtBoxHenrique = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.txtBoxMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Média Idades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jucelia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sophia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Henrique";
            // 
            // txtBoxJucelia
            // 
            this.txtBoxJucelia.Location = new System.Drawing.Point(119, 129);
            this.txtBoxJucelia.Name = "txtBoxJucelia";
            this.txtBoxJucelia.Size = new System.Drawing.Size(35, 20);
            this.txtBoxJucelia.TabIndex = 4;
            // 
            // txtBoxSophia
            // 
            this.txtBoxSophia.Location = new System.Drawing.Point(119, 176);
            this.txtBoxSophia.Name = "txtBoxSophia";
            this.txtBoxSophia.Size = new System.Drawing.Size(35, 20);
            this.txtBoxSophia.TabIndex = 5;
            // 
            // txtBoxHenrique
            // 
            this.txtBoxHenrique.Location = new System.Drawing.Point(119, 217);
            this.txtBoxHenrique.Name = "txtBoxHenrique";
            this.txtBoxHenrique.Size = new System.Drawing.Size(35, 20);
            this.txtBoxHenrique.TabIndex = 6;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(119, 271);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(182, 57);
            this.btnResultado.TabIndex = 7;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // txtBoxMedia
            // 
            this.txtBoxMedia.Location = new System.Drawing.Point(176, 245);
            this.txtBoxMedia.Name = "txtBoxMedia";
            this.txtBoxMedia.Size = new System.Drawing.Size(67, 20);
            this.txtBoxMedia.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 357);
            this.Controls.Add(this.txtBoxMedia);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtBoxHenrique);
            this.Controls.Add(this.txtBoxSophia);
            this.Controls.Add(this.txtBoxJucelia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxJucelia;
        private System.Windows.Forms.TextBox txtBoxSophia;
        private System.Windows.Forms.TextBox txtBoxHenrique;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.TextBox txtBoxMedia;
    }
}

