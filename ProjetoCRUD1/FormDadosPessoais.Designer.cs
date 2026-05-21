using System;

namespace ProjetoCRUD1
{
    partial class FormDadosPessoais
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
            
        private void FormDadosPessoais_Load(object sender, EventArgs e)
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.DtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.RbMasculino = new System.Windows.Forms.RadioButton();
            this.RbFeminino = new System.Windows.Forms.RadioButton();
            this.BtnAvancar = new System.Windows.Forms.Button();
            this.LbNome = new System.Windows.Forms.Label();
            this.LbEndereco = new System.Windows.Forms.Label();
            this.LbCep = new System.Windows.Forms.Label();
            this.LbCidade = new System.Windows.Forms.Label();
            this.LbEstado = new System.Windows.Forms.Label();
            this.LbDataNasc = new System.Windows.Forms.Label();
            this.LbDadosPessoais = new System.Windows.Forms.Label();
            this.LbSexo = new System.Windows.Forms.Label();
            this.TxtCep = new System.Windows.Forms.MaskedTextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(89, 84);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(208, 22);
            this.TxtNome.TabIndex = 2;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(89, 122);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(248, 22);
            this.TxtEndereco.TabIndex = 4;
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(89, 196);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(63, 24);
            this.CmbEstado.TabIndex = 8;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(89, 236);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(219, 22);
            this.TxtCidade.TabIndex = 10;
            // 
            // DtpNascimento
            // 
            this.DtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpNascimento.Location = new System.Drawing.Point(518, 82);
            this.DtpNascimento.Name = "DtpNascimento";
            this.DtpNascimento.Size = new System.Drawing.Size(119, 22);
            this.DtpNascimento.TabIndex = 12;
            // 
            // RbMasculino
            // 
            this.RbMasculino.AutoSize = true;
            this.RbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMasculino.Location = new System.Drawing.Point(473, 174);
            this.RbMasculino.Name = "RbMasculino";
            this.RbMasculino.Size = new System.Drawing.Size(89, 20);
            this.RbMasculino.TabIndex = 14;
            this.RbMasculino.TabStop = true;
            this.RbMasculino.Text = "Masculino";
            this.RbMasculino.UseVisualStyleBackColor = true;
            // 
            // RbFeminino
            // 
            this.RbFeminino.AutoSize = true;
            this.RbFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFeminino.Location = new System.Drawing.Point(473, 200);
            this.RbFeminino.Name = "RbFeminino";
            this.RbFeminino.Size = new System.Drawing.Size(83, 20);
            this.RbFeminino.TabIndex = 15;
            this.RbFeminino.TabStop = true;
            this.RbFeminino.Text = "Feminino";
            this.RbFeminino.UseVisualStyleBackColor = true;
            // 
            // BtnAvancar
            // 
            this.BtnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvancar.Location = new System.Drawing.Point(465, 300);
            this.BtnAvancar.Name = "BtnAvancar";
            this.BtnAvancar.Size = new System.Drawing.Size(97, 39);
            this.BtnAvancar.TabIndex = 17;
            this.BtnAvancar.Text = "Avançar";
            this.BtnAvancar.UseVisualStyleBackColor = true;
            this.BtnAvancar.Click += new System.EventHandler(this.BtnAvancar_Click);
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNome.Location = new System.Drawing.Point(32, 84);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(45, 16);
            this.LbNome.TabIndex = 1;
            this.LbNome.Text = "Nome:";
            // 
            // LbEndereco
            // 
            this.LbEndereco.AutoSize = true;
            this.LbEndereco.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEndereco.Location = new System.Drawing.Point(17, 122);
            this.LbEndereco.Name = "LbEndereco";
            this.LbEndereco.Size = new System.Drawing.Size(66, 16);
            this.LbEndereco.TabIndex = 3;
            this.LbEndereco.Text = "Endereço:";
            // 
            // LbCep
            // 
            this.LbCep.AutoSize = true;
            this.LbCep.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCep.Location = new System.Drawing.Point(43, 161);
            this.LbCep.Name = "LbCep";
            this.LbCep.Size = new System.Drawing.Size(34, 16);
            this.LbCep.TabIndex = 5;
            this.LbCep.Text = "Cep:";
            // 
            // LbCidade
            // 
            this.LbCidade.AutoSize = true;
            this.LbCidade.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCidade.Location = new System.Drawing.Point(32, 239);
            this.LbCidade.Name = "LbCidade";
            this.LbCidade.Size = new System.Drawing.Size(51, 16);
            this.LbCidade.TabIndex = 9;
            this.LbCidade.Text = "Cidade:";
            // 
            // LbEstado
            // 
            this.LbEstado.AutoSize = true;
            this.LbEstado.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstado.Location = new System.Drawing.Point(31, 200);
            this.LbEstado.Name = "LbEstado";
            this.LbEstado.Size = new System.Drawing.Size(52, 16);
            this.LbEstado.TabIndex = 7;
            this.LbEstado.Text = "Estado:";
            // 
            // LbDataNasc
            // 
            this.LbDataNasc.AutoSize = true;
            this.LbDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDataNasc.Location = new System.Drawing.Point(342, 84);
            this.LbDataNasc.Name = "LbDataNasc";
            this.LbDataNasc.Size = new System.Drawing.Size(148, 16);
            this.LbDataNasc.TabIndex = 11;
            this.LbDataNasc.Text = "Data de Nascimento";
            // 
            // LbDadosPessoais
            // 
            this.LbDadosPessoais.AutoSize = true;
            this.LbDadosPessoais.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDadosPessoais.Location = new System.Drawing.Point(209, 9);
            this.LbDadosPessoais.Name = "LbDadosPessoais";
            this.LbDadosPessoais.Size = new System.Drawing.Size(252, 40);
            this.LbDadosPessoais.TabIndex = 0;
            this.LbDadosPessoais.Text = "DADOS PESSOAIS";
            // 
            // LbSexo
            // 
            this.LbSexo.AutoSize = true;
            this.LbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSexo.Location = new System.Drawing.Point(503, 141);
            this.LbSexo.Name = "LbSexo";
            this.LbSexo.Size = new System.Drawing.Size(42, 16);
            this.LbSexo.TabIndex = 13;
            this.LbSexo.Text = "Sexo";
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(89, 155);
            this.TxtCep.Mask = "00000-000";
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(100, 22);
            this.TxtCep.TabIndex = 6;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(129, 300);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(97, 39);
            this.BtnLimpar.TabIndex = 16;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(345, 300);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(97, 39);
            this.BtnVoltar.TabIndex = 18;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FormDadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.TxtCep);
            this.Controls.Add(this.LbSexo);
            this.Controls.Add(this.LbDadosPessoais);
            this.Controls.Add(this.LbDataNasc);
            this.Controls.Add(this.LbEstado);
            this.Controls.Add(this.LbCidade);
            this.Controls.Add(this.LbCep);
            this.Controls.Add(this.LbEndereco);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.BtnAvancar);
            this.Controls.Add(this.RbFeminino);
            this.Controls.Add(this.RbMasculino);
            this.Controls.Add(this.DtpNascimento);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDadosPessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Pessoais";
            this.Load += new System.EventHandler(this.FormDadosPessoais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.DateTimePicker DtpNascimento;
        private System.Windows.Forms.RadioButton RbMasculino;
        private System.Windows.Forms.RadioButton RbFeminino;
        private System.Windows.Forms.Button BtnAvancar;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Label LbEndereco;
        private System.Windows.Forms.Label LbCep;
        private System.Windows.Forms.Label LbCidade;
        private System.Windows.Forms.Label LbEstado;
        private System.Windows.Forms.Label LbDataNasc;
        private System.Windows.Forms.Label LbDadosPessoais;
        private System.Windows.Forms.Label LbSexo;
        private System.Windows.Forms.MaskedTextBox TxtCep;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnVoltar;
    }
}