namespace lab_genetic_algorithms_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIndividuo = new System.Windows.Forms.RichTextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtPopulacao = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtIndividuo
            // 
            this.txtIndividuo.Location = new System.Drawing.Point(12, 41);
            this.txtIndividuo.Name = "txtIndividuo";
            this.txtIndividuo.Size = new System.Drawing.Size(1256, 96);
            this.txtIndividuo.TabIndex = 0;
            this.txtIndividuo.Text = "";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(1193, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Location = new System.Drawing.Point(12, 143);
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(1256, 295);
            this.txtPopulacao.TabIndex = 2;
            this.txtPopulacao.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 450);
            this.Controls.Add(this.txtPopulacao);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtIndividuo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtIndividuo;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RichTextBox txtPopulacao;
    }
}
