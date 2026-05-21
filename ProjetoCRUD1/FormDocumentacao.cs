using ProjetoCRUD1;
using System;
using System.Windows.Forms;

namespace ProjetoCRUD1
{
    public partial class FormDocumentacao : Form
    {
        public FormDocumentacao()
        {
            InitializeComponent();

            TxtCpf.Text = Global.Cpf;
            TxtRg.Text = Global.Rg;
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            Global.Cpf = TxtCpf.Text;
            Global.Rg = TxtRg.Text;

            FormInteresses tela = new FormInteresses();
            tela.Show();
            this.Hide();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Global.Cpf = TxtCpf.Text;
            Global.Rg = TxtRg.Text;

            FormDadosPessoais tela = new FormDadosPessoais();
            tela.Show();
            this.Hide();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtCpf.Clear();
            TxtRg.Clear();
        }
    }
}