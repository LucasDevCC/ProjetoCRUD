using ProjetoCRUD1;
using System;
using System.Windows.Forms;

namespace ProjetoCRUD1
{
    public partial class FormDadosPessoais : Form
    {
        public FormDadosPessoais()
        {
            {
                InitializeComponent();

                CmbEstado.Items.Add("SP");
                CmbEstado.Items.Add("RJ");
                CmbEstado.Items.Add("MG");
                CmbEstado.Items.Add("BA");
                CmbEstado.Items.Add("PE");
                CmbEstado.Items.Add("CE");
            }

            { 
            InitializeComponent();

            TxtNome.Text = Global.Nome;
            TxtEndereco.Text = Global.Endereco;
            TxtCep.Text = Global.Cep;
            CmbEstado.Text = Global.Estado;
            TxtCidade.Text = Global.Cidade;

            if (Global.Sexo == "Masculino")
                RbMasculino.Checked = true;
            else if (Global.Sexo == "Feminino")
                RbFeminino.Checked = true;
            }
            InitializeComponent();

            ColocarTexto("TxtNome", Global.Nome);
            ColocarTexto("TxtEndereco", Global.Endereco);
            ColocarTexto("TxtCep", Global.Cep);
            ColocarTexto("CmbEstado", Global.Estado);
            ColocarTexto("TxtCidade", Global.Cidade);

            if (Global.Sexo == "Masculino")
                RbMasculino.Checked = true;
            else if (Global.Sexo == "Feminino")
                RbFeminino.Checked = true;
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
           
            
            
            Global.Nome = PegarTexto("TxtNome");
            Global.Endereco = PegarTexto("TxtEndereco");
            Global.Cep = PegarTexto("TxtCep");
            Global.Estado = PegarTexto("CmbEstado");
            Global.Cidade = PegarTexto("TxtCidade");
            Global.Nascimento = DtpNascimento.Value.ToShortDateString();

            if (EstaMarcado("RbMasculino"))
            {
                Global.Sexo = "Masculino";
            }
            else if (EstaMarcado("RbFeminino"))
            {
                Global.Sexo = "Feminino";
            }
            else
            {
                Global.Sexo = "";
            }

            FormDocumentacao tela = new FormDocumentacao();
            tela.Show();
            this.Hide();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";

                if (c is MaskedTextBox)
                    c.Text = "";

                if (c is ComboBox)
                    c.Text = "";

                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
            }
        }
            private string PegarTexto(string nomeControle)
        {
            Control[] controles = this.Controls.Find(nomeControle, true);

            if (controles.Length > 0)
                return controles[0].Text;

            return "";
        }
        private bool EstaMarcado(string nomeControle)
        {
            Control[] controles = this.Controls.Find(nomeControle, true);

            if (controles.Length > 0)
                return ((RadioButton)controles[0]).Checked;

            return false;
        }
        private void ColocarTexto(string nomeControle, string valor)
        {
            Control[] controles = this.Controls.Find(nomeControle, true);

            if (controles.Length > 0)
                controles[0].Text = valor;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FormAbertura tela = new FormAbertura();
            tela.Show();
            this.Hide();
        }
    }
}