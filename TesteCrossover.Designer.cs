namespace lab_genetic_algorithms_1
{
    partial class TesteCrossover
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
            this.txtPai = new System.Windows.Forms.TextBox();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.txtFilho1 = new System.Windows.Forms.TextBox();
            this.txtFilho2 = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtPopulacao = new System.Windows.Forms.RichTextBox();
            this.btnInterar = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPai
            // 
            this.txtPai.Location = new System.Drawing.Point(12, 12);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(1458, 23);
            this.txtPai.TabIndex = 0;
            // 
            // txtMae
            // 
            this.txtMae.Location = new System.Drawing.Point(12, 41);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(1458, 23);
            this.txtMae.TabIndex = 1;
            // 
            // txtFilho1
            // 
            this.txtFilho1.Location = new System.Drawing.Point(12, 99);
            this.txtFilho1.Name = "txtFilho1";
            this.txtFilho1.Size = new System.Drawing.Size(1458, 23);
            this.txtFilho1.TabIndex = 2;
            // 
            // txtFilho2
            // 
            this.txtFilho2.Location = new System.Drawing.Point(12, 128);
            this.txtFilho2.Name = "txtFilho2";
            this.txtFilho2.Size = new System.Drawing.Size(1458, 23);
            this.txtFilho2.TabIndex = 3;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(1307, 600);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(163, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Location = new System.Drawing.Point(12, 180);
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(1458, 414);
            this.txtPopulacao.TabIndex = 5;
            this.txtPopulacao.Text = "";
            // 
            // btnInterar
            // 
            this.btnInterar.Location = new System.Drawing.Point(1135, 600);
            this.btnInterar.Name = "btnInterar";
            this.btnInterar.Size = new System.Drawing.Size(166, 23);
            this.btnInterar.TabIndex = 6;
            this.btnInterar.Text = "Interar";
            this.btnInterar.UseVisualStyleBackColor = true;
            this.btnInterar.Click += new System.EventHandler(this.btnInterar_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(1016, 608);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(40, 15);
            this.lblMedia.TabIndex = 7;
            this.lblMedia.Text = "Media";
            // 
            // TesteCrossover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 635);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnInterar);
            this.Controls.Add(this.txtPopulacao);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtFilho2);
            this.Controls.Add(this.txtFilho1);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.txtPai);
            this.Name = "TesteCrossover";
            this.Text = "TesteCrossover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPai;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.TextBox txtFilho1;
        private System.Windows.Forms.TextBox txtFilho2;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RichTextBox txtPopulacao;
        private System.Windows.Forms.Button btnInterar;
        private System.Windows.Forms.Label lblMedia;
    }
}