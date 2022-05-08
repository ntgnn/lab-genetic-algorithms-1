namespace lab_genetic_algorithms_1
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.zedPopulacao = new ZedGraph.ZedGraphControl();
            this.zedMediaPopulacao = new ZedGraph.ZedGraphControl();
            this.txtMelhoresIndividuos = new System.Windows.Forms.RichTextBox();
            this.txtPioresIndividuos = new System.Windows.Forms.RichTextBox();
            this.lblMelhoresIndividuos = new System.Windows.Forms.Label();
            this.lblPioresIndividuos = new System.Windows.Forms.Label();
            this.lblTaxaCrossover = new System.Windows.Forms.Label();
            this.lblTaxaMutacao = new System.Windows.Forms.Label();
            this.lblEvolucoes = new System.Windows.Forms.Label();
            this.txtTaxaCrossover = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.MaskedTextBox();
            this.txtEvolucoes = new System.Windows.Forms.MaskedTextBox();
            this.btnCriarPopulacao = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedPopulacao
            // 
            this.zedPopulacao.Location = new System.Drawing.Point(12, 70);
            this.zedPopulacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedPopulacao.Name = "zedPopulacao";
            this.zedPopulacao.ScrollGrace = 0D;
            this.zedPopulacao.ScrollMaxX = 0D;
            this.zedPopulacao.ScrollMaxY = 0D;
            this.zedPopulacao.ScrollMaxY2 = 0D;
            this.zedPopulacao.ScrollMinX = 0D;
            this.zedPopulacao.ScrollMinY = 0D;
            this.zedPopulacao.ScrollMinY2 = 0D;
            this.zedPopulacao.Size = new System.Drawing.Size(598, 254);
            this.zedPopulacao.TabIndex = 0;
            this.zedPopulacao.UseExtendedPrintDialog = true;
            // 
            // zedMediaPopulacao
            // 
            this.zedMediaPopulacao.Location = new System.Drawing.Point(619, 70);
            this.zedMediaPopulacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedMediaPopulacao.Name = "zedMediaPopulacao";
            this.zedMediaPopulacao.ScrollGrace = 0D;
            this.zedMediaPopulacao.ScrollMaxX = 0D;
            this.zedMediaPopulacao.ScrollMaxY = 0D;
            this.zedMediaPopulacao.ScrollMaxY2 = 0D;
            this.zedMediaPopulacao.ScrollMinX = 0D;
            this.zedMediaPopulacao.ScrollMinY = 0D;
            this.zedMediaPopulacao.ScrollMinY2 = 0D;
            this.zedMediaPopulacao.Size = new System.Drawing.Size(583, 254);
            this.zedMediaPopulacao.TabIndex = 1;
            this.zedMediaPopulacao.UseExtendedPrintDialog = true;
            // 
            // txtMelhoresIndividuos
            // 
            this.txtMelhoresIndividuos.Location = new System.Drawing.Point(12, 356);
            this.txtMelhoresIndividuos.Name = "txtMelhoresIndividuos";
            this.txtMelhoresIndividuos.Size = new System.Drawing.Size(599, 263);
            this.txtMelhoresIndividuos.TabIndex = 2;
            this.txtMelhoresIndividuos.Text = "";
            // 
            // txtPioresIndividuos
            // 
            this.txtPioresIndividuos.Location = new System.Drawing.Point(617, 356);
            this.txtPioresIndividuos.Name = "txtPioresIndividuos";
            this.txtPioresIndividuos.Size = new System.Drawing.Size(585, 263);
            this.txtPioresIndividuos.TabIndex = 3;
            this.txtPioresIndividuos.Text = "";
            // 
            // lblMelhoresIndividuos
            // 
            this.lblMelhoresIndividuos.AutoSize = true;
            this.lblMelhoresIndividuos.Location = new System.Drawing.Point(13, 338);
            this.lblMelhoresIndividuos.Name = "lblMelhoresIndividuos";
            this.lblMelhoresIndividuos.Size = new System.Drawing.Size(114, 15);
            this.lblMelhoresIndividuos.TabIndex = 4;
            this.lblMelhoresIndividuos.Text = "Melhores Individuos";
            // 
            // lblPioresIndividuos
            // 
            this.lblPioresIndividuos.AutoSize = true;
            this.lblPioresIndividuos.Location = new System.Drawing.Point(619, 338);
            this.lblPioresIndividuos.Name = "lblPioresIndividuos";
            this.lblPioresIndividuos.Size = new System.Drawing.Size(97, 15);
            this.lblPioresIndividuos.TabIndex = 5;
            this.lblPioresIndividuos.Text = "Piores Individuos";
            // 
            // lblTaxaCrossover
            // 
            this.lblTaxaCrossover.AutoSize = true;
            this.lblTaxaCrossover.Location = new System.Drawing.Point(12, 9);
            this.lblTaxaCrossover.Name = "lblTaxaCrossover";
            this.lblTaxaCrossover.Size = new System.Drawing.Size(101, 15);
            this.lblTaxaCrossover.TabIndex = 6;
            this.lblTaxaCrossover.Text = "Taxa de Crossover";
            // 
            // lblTaxaMutacao
            // 
            this.lblTaxaMutacao.AutoSize = true;
            this.lblTaxaMutacao.Location = new System.Drawing.Point(13, 43);
            this.lblTaxaMutacao.Name = "lblTaxaMutacao";
            this.lblTaxaMutacao.Size = new System.Drawing.Size(96, 15);
            this.lblTaxaMutacao.TabIndex = 7;
            this.lblTaxaMutacao.Text = "Taxa de Mutação";
            // 
            // lblEvolucoes
            // 
            this.lblEvolucoes.AutoSize = true;
            this.lblEvolucoes.Location = new System.Drawing.Point(367, 9);
            this.lblEvolucoes.Name = "lblEvolucoes";
            this.lblEvolucoes.Size = new System.Drawing.Size(60, 15);
            this.lblEvolucoes.TabIndex = 8;
            this.lblEvolucoes.Text = "Evoluções";
            // 
            // txtTaxaCrossover
            // 
            this.txtTaxaCrossover.Location = new System.Drawing.Point(119, 6);
            this.txtTaxaCrossover.Mask = "0.00";
            this.txtTaxaCrossover.Name = "txtTaxaCrossover";
            this.txtTaxaCrossover.Size = new System.Drawing.Size(204, 23);
            this.txtTaxaCrossover.TabIndex = 9;
            this.txtTaxaCrossover.Text = "080";
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Location = new System.Drawing.Point(121, 40);
            this.txtTaxaMutacao.Mask = "0.00";
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(202, 23);
            this.txtTaxaMutacao.TabIndex = 10;
            this.txtTaxaMutacao.Text = "001";
            // 
            // txtEvolucoes
            // 
            this.txtEvolucoes.Location = new System.Drawing.Point(432, 6);
            this.txtEvolucoes.Mask = "00000";
            this.txtEvolucoes.Name = "txtEvolucoes";
            this.txtEvolucoes.Size = new System.Drawing.Size(178, 23);
            this.txtEvolucoes.TabIndex = 11;
            this.txtEvolucoes.Text = "100";
            this.txtEvolucoes.ValidatingType = typeof(int);
            // 
            // btnCriarPopulacao
            // 
            this.btnCriarPopulacao.Location = new System.Drawing.Point(933, 14);
            this.btnCriarPopulacao.Name = "btnCriarPopulacao";
            this.btnCriarPopulacao.Size = new System.Drawing.Size(133, 44);
            this.btnCriarPopulacao.TabIndex = 12;
            this.btnCriarPopulacao.Text = "Criar População";
            this.btnCriarPopulacao.UseVisualStyleBackColor = true;
            this.btnCriarPopulacao.Click += new System.EventHandler(this.btnCriarPopulacao_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(1072, 13);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(130, 45);
            this.btnExecutar.TabIndex = 13;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 631);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.btnCriarPopulacao);
            this.Controls.Add(this.txtEvolucoes);
            this.Controls.Add(this.txtTaxaMutacao);
            this.Controls.Add(this.txtTaxaCrossover);
            this.Controls.Add(this.lblEvolucoes);
            this.Controls.Add(this.lblTaxaMutacao);
            this.Controls.Add(this.lblTaxaCrossover);
            this.Controls.Add(this.lblPioresIndividuos);
            this.Controls.Add(this.lblMelhoresIndividuos);
            this.Controls.Add(this.txtPioresIndividuos);
            this.Controls.Add(this.txtMelhoresIndividuos);
            this.Controls.Add(this.zedMediaPopulacao);
            this.Controls.Add(this.zedPopulacao);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedPopulacao;
        private ZedGraph.ZedGraphControl zedMediaPopulacao;
        private System.Windows.Forms.RichTextBox txtMelhoresIndividuos;
        private System.Windows.Forms.RichTextBox txtPioresIndividuos;
        private System.Windows.Forms.Label lblPioresIndividuos;
        private System.Windows.Forms.Label lblMelhoresIndividuos;
        private System.Windows.Forms.Label lblTaxaCrossover;
        private System.Windows.Forms.Label lblTaxaMutacao;
        private System.Windows.Forms.Label lblEvolucoes;
        private System.Windows.Forms.MaskedTextBox txtTaxaCrossover;
        private System.Windows.Forms.MaskedTextBox txtTaxaMutacao;
        private System.Windows.Forms.MaskedTextBox txtEvolucoes;
        private System.Windows.Forms.Button btnCriarPopulacao;
        private System.Windows.Forms.Button btnExecutar;
    }
}