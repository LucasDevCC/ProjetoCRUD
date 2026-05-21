using System;

namespace ProjetoCRUD1
{
    partial class FormDocumentacao
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
        private void FormDocumentacao_Load(object sender, EventArgs e)
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnAvancar = new System.Windows.Forms.Button();
            this.LbCpf = new System.Windows.Forms.Label();
            this.LbRg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.TxtRg = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(67, 213);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(110, 40);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(217, 213);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(110, 40);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnAvancar
            // 
            this.BtnAvancar.Location = new System.Drawing.Point(364, 213);
            this.BtnAvancar.Name = "BtnAvancar";
            this.BtnAvancar.Size = new System.Drawing.Size(110, 40);
            this.BtnAvancar.TabIndex = 7;
            this.BtnAvancar.Text = "Avançar";
            this.BtnAvancar.UseVisualStyleBackColor = true;
            this.BtnAvancar.Click += new System.EventHandler(this.BtnAvancar_Click);
            // 
            // LbCpf
            // 
            this.LbCpf.AutoSize = true;
            this.LbCpf.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCpf.Location = new System.Drawing.Point(47, 104);
            this.LbCpf.Name = "LbCpf";
            this.LbCpf.Size = new System.Drawing.Size(42, 25);
            this.LbCpf.TabIndex = 1;
            this.LbCpf.Text = "CPF";
            // 
            // LbRg
            // 
            this.LbRg.AutoSize = true;
            this.LbRg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRg.Location = new System.Drawing.Point(333, 104);
            this.LbRg.Name = "LbRg";
            this.LbRg.Size = new System.Drawing.Size(35, 25);
            this.LbRg.TabIndex = 3;
            this.LbRg.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOCUMENTAÇÃO";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(41, 141);
            this.TxtCpf.Mask = "000.000.000-00";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(180, 22);
            this.TxtCpf.TabIndex = 2;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(338, 141);
            this.TxtRg.Mask = "00.000.000-0";
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(180, 22);
            this.TxtRg.TabIndex = 4;
            // 
            // FormDocumentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 363);
            this.Controls.Add(this.TxtRg);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbRg);
            this.Controls.Add(this.LbCpf);
            this.Controls.Add(this.BtnAvancar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDocumentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentação";
            this.Load += new System.EventHandler(this.FormDocumentacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnAvancar;
        private System.Windows.Forms.Label LbCpf;
        private System.Windows.Forms.Label LbRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtCpf;
        private System.Windows.Forms.MaskedTextBox TxtRg;
    }

}