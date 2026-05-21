using ProjetoCRUD1;
using System;
using System.Windows.Forms;

namespace ProjetoCRUD1
{
    public partial class FormAbertura : Form
    {
        public FormAbertura()
        {
            InitializeComponent();
           // Banco.Conectar().Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Global.LimparTudo();
            Global.Operacao = "CREATE";

            FormDadosPessoais tela = new FormDadosPessoais();
            tela.Show();
            this.Hide();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            Global.LimparTudo();
            Global.Operacao = "READ";

            FormInteresses tela = new FormInteresses();
            tela.Show();
            this.Hide();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Global.LimparTudo();
            Global.Operacao = "UPDATE";

            FormDadosPessoais tela = new FormDadosPessoais();
            tela.Show();
            this.Hide();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Global.LimparTudo();
            Global.Operacao = "DELETE";

            FormInteresses tela = new FormInteresses();
            tela.Show();
            this.Hide();
        }

        
    }
}