using ProjetoCRUD1;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjetoCRUD1
{
    public partial class FormInteresses : Form
    {
        public FormInteresses()
        {
            InitializeComponent();

            ChkBicicleta.Checked = Global.Bicicleta == "Sim";
            ChkMoto.Checked = Global.Moto == "Sim";
            ChkAuto.Checked = Global.Auto == "Sim";

            ChkLer.Checked = Global.Ler == "Sim";
            ChkMusica.Checked = Global.Musica == "Sim";
            ChkCinema.Checked = Global.Cinema == "Sim";
            ChkBares.Checked = Global.Bares == "Sim";
            ChkConversar.Checked = Global.Conversar == "Sim";

            ChkFutebol.Checked = Global.Futebol == "Sim";
            ChkBasquete.Checked = Global.Basquete == "Sim";
            ChkVolei.Checked = Global.Volei == "Sim";
            ChkAtletismo.Checked = Global.Atletismo == "Sim";
            ChkPescaria.Checked = Global.Pescaria == "Sim";
            ChkParaquedismo.Checked = Global.Paraquedismo == "Sim";
        }

        private void SalvarChecks()
        {
            Global.Bicicleta = ChkBicicleta.Checked ? "Sim" : "";
            Global.Moto = ChkMoto.Checked ? "Sim" : "";
            Global.Auto = ChkAuto.Checked ? "Sim" : "";

            Global.Ler = ChkLer.Checked ? "Sim" : "";
            Global.Musica = ChkMusica.Checked ? "Sim" : "";
            Global.Cinema = ChkCinema.Checked ? "Sim" : "";
            Global.Bares = ChkBares.Checked ? "Sim" : "";
            Global.Conversar = ChkConversar.Checked ? "Sim" : "";

            Global.Futebol = ChkFutebol.Checked ? "Sim" : "";
            Global.Basquete = ChkBasquete.Checked ? "Sim" : "";
            Global.Volei = ChkVolei.Checked ? "Sim" : "";
            Global.Atletismo = ChkAtletismo.Checked ? "Sim" : "";
            Global.Pescaria = ChkPescaria.Checked ? "Sim" : "";
            Global.Paraquedismo = ChkParaquedismo.Checked ? "Sim" : "";
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            SalvarChecks();

            using (SQLiteConnection conexao = Banco.Conectar())
            {
                string sql = @"INSERT INTO pessoas 
                (nome, endereco, cep, estado, cidade, nascimento, sexo, cpf, rg,
                bicicleta, moto, auto, ler, musica, cinema, bares, conversar,
                futebol, basquete, volei, atletismo, pescaria, paraquedismo)
                VALUES
                (@nome, @endereco, @cep, @estado, @cidade, @nascimento, @sexo, @cpf, @rg,
                @bicicleta, @moto, @auto, @ler, @musica, @cinema, @bares, @conversar,
                @futebol, @basquete, @volei, @atletismo, @pescaria, @paraquedismo)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", Global.Nome);
                cmd.Parameters.AddWithValue("@endereco", Global.Endereco);
                cmd.Parameters.AddWithValue("@cep", Global.Cep);
                cmd.Parameters.AddWithValue("@estado", Global.Estado);
                cmd.Parameters.AddWithValue("@cidade", Global.Cidade);
                cmd.Parameters.AddWithValue("@nascimento", Global.Nascimento);
                cmd.Parameters.AddWithValue("@sexo", Global.Sexo);
                cmd.Parameters.AddWithValue("@cpf", Global.Cpf);
                cmd.Parameters.AddWithValue("@rg", Global.Rg);

                cmd.Parameters.AddWithValue("@bicicleta", Global.Bicicleta);
                cmd.Parameters.AddWithValue("@moto", Global.Moto);
                cmd.Parameters.AddWithValue("@auto", Global.Auto);
                cmd.Parameters.AddWithValue("@ler", Global.Ler);
                cmd.Parameters.AddWithValue("@musica", Global.Musica);
                cmd.Parameters.AddWithValue("@cinema", Global.Cinema);
                cmd.Parameters.AddWithValue("@bares", Global.Bares);
                cmd.Parameters.AddWithValue("@conversar", Global.Conversar);
                cmd.Parameters.AddWithValue("@futebol", Global.Futebol);
                cmd.Parameters.AddWithValue("@basquete", Global.Basquete);
                cmd.Parameters.AddWithValue("@volei", Global.Volei);
                cmd.Parameters.AddWithValue("@atletismo", Global.Atletismo);
                cmd.Parameters.AddWithValue("@pescaria", Global.Pescaria);
                cmd.Parameters.AddWithValue("@paraquedismo", Global.Paraquedismo);

                cmd.ExecuteNonQuery();

                long idGerado = conexao.LastInsertRowId;
                MessageBox.Show("Registro gravado com sucesso! ID: " + idGerado);
            }

            Log.Registrar("CREATE - Registro gravado: " + Global.Nome);
            Global.LimparTudo();

            FormAbertura tela = new FormAbertura();
            tela.Show();
            this.Hide();
        }

        private void BtnLer_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
            {
                MessageBox.Show("Digite o ID.");
                return;
            }

            using (SQLiteConnection conexao = Banco.Conectar())
            {
                string sql = "SELECT * FROM pessoas WHERE id=@id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TxtId.Text));

                using (SQLiteDataReader leitor = cmd.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        string hobbies = "";
                        string veiculos = "";
                        string esportes = "";

                        // HOBBIES
                        if (leitor["ler"].ToString() == "Sim")
                            hobbies += "Ler\n";

                        if (leitor["musica"].ToString() == "Sim")
                            hobbies += "Música\n";

                        if (leitor["cinema"].ToString() == "Sim")
                            hobbies += "Cinema\n";

                        if (leitor["bares"].ToString() == "Sim")
                            hobbies += "Bares\n";

                        if (leitor["conversar"].ToString() == "Sim")
                            hobbies += "Conversar\n";

                        // VEÍCULOS
                        if (leitor["bicicleta"].ToString() == "Sim")
                            veiculos += "Bicicleta\n";

                        if (leitor["moto"].ToString() == "Sim")
                            veiculos += "Moto\n";

                        if (leitor["auto"].ToString() == "Sim")
                            veiculos += "Automóvel\n";

                        // ESPORTES
                        if (leitor["futebol"].ToString() == "Sim")
                            esportes += "Futebol\n";

                        if (leitor["basquete"].ToString() == "Sim")
                            esportes += "Basquete\n";

                        if (leitor["volei"].ToString() == "Sim")
                            esportes += "Vôlei\n";

                        if (leitor["atletismo"].ToString() == "Sim")
                            esportes += "Atletismo\n";

                        if (leitor["pescaria"].ToString() == "Sim")
                            esportes += "Pescaria\n";

                        if (leitor["paraquedismo"].ToString() == "Sim")
                            esportes += "Paraquedismo\n";

                        string texto =
                            "ID: " + leitor["id"] + "\n" +
                            "Nome: " + leitor["nome"] + "\n" +
                            "Endereço: " + leitor["endereco"] + "\n" +
                            "CEP: " + leitor["cep"] + "\n" +
                            "Estado: " + leitor["estado"] + "\n" +
                            "Cidade: " + leitor["cidade"] + "\n" +
                            "Nascimento: " + leitor["nascimento"] + "\n" +
                            "Sexo: " + leitor["sexo"] + "\n" +
                            "CPF: " + leitor["cpf"] + "\n" +
                            "RG: " + leitor["rg"] + "\n\n" +

                            "Hobbies:\n" + hobbies + "\n" +
                            "Veículos:\n" + veiculos + "\n" +
                            "Esportes:\n" + esportes;



                        MessageBox.Show(texto);
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado.");
                    }
                }
            }

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            SalvarChecks();

            using (SQLiteConnection conexao = Banco.Conectar())
            {
                string sql = @"UPDATE pessoas SET
                nome=@nome, endereco=@endereco, cep=@cep, estado=@estado,
                cidade=@cidade, nascimento=@nascimento, sexo=@sexo,
                cpf=@cpf, rg=@rg,
                bicicleta=@bicicleta, moto=@moto, auto=@auto,
                ler=@ler, musica=@musica, cinema=@cinema, bares=@bares, conversar=@conversar,
                futebol=@futebol, basquete=@basquete, volei=@volei,
                atletismo=@atletismo, pescaria=@pescaria, paraquedismo=@paraquedismo
                WHERE id=@id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", Global.Id);
                cmd.Parameters.AddWithValue("@nome", Global.Nome);
                cmd.Parameters.AddWithValue("@endereco", Global.Endereco);
                cmd.Parameters.AddWithValue("@cep", Global.Cep);
                cmd.Parameters.AddWithValue("@estado", Global.Estado);
                cmd.Parameters.AddWithValue("@cidade", Global.Cidade);
                cmd.Parameters.AddWithValue("@nascimento", Global.Nascimento);
                cmd.Parameters.AddWithValue("@sexo", Global.Sexo);
                cmd.Parameters.AddWithValue("@cpf", Global.Cpf);
                cmd.Parameters.AddWithValue("@rg", Global.Rg);
                cmd.Parameters.AddWithValue("@bicicleta", Global.Bicicleta);
                cmd.Parameters.AddWithValue("@moto", Global.Moto);
                cmd.Parameters.AddWithValue("@auto", Global.Auto);
                cmd.Parameters.AddWithValue("@ler", Global.Ler);
                cmd.Parameters.AddWithValue("@musica", Global.Musica);
                cmd.Parameters.AddWithValue("@cinema", Global.Cinema);
                cmd.Parameters.AddWithValue("@bares", Global.Bares);
                cmd.Parameters.AddWithValue("@conversar", Global.Conversar);
                cmd.Parameters.AddWithValue("@futebol", Global.Futebol);
                cmd.Parameters.AddWithValue("@basquete", Global.Basquete);
                cmd.Parameters.AddWithValue("@volei", Global.Volei);
                cmd.Parameters.AddWithValue("@atletismo", Global.Atletismo);
                cmd.Parameters.AddWithValue("@pescaria", Global.Pescaria);
                cmd.Parameters.AddWithValue("@paraquedismo", Global.Paraquedismo);

                int linhas = cmd.ExecuteNonQuery();

                if (linhas > 0)
                {
                    MessageBox.Show("Registro atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado.");
                }
            }

            Log.Registrar("UPDATE - Registro atualizado ID: " + TxtId.Text);
            SalvarChecks();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
            {
                MessageBox.Show("Digite o ID do registro para deletar.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente deletar esse registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                using (SQLiteConnection conexao = Banco.Conectar())
                {
                    string sql = "DELETE FROM pessoas WHERE id = @id";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TxtId.Text));

                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas > 0)
                    {
                        Log.Registrar("DELETE - Registro deletado ID: " + TxtId.Text);
                        MessageBox.Show("Registro deletado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado com esse ID.");
                    }
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FormDocumentacao tela = new FormDocumentacao();
            tela.Show();
            this.Hide();
        }
        private void FormInteresses_Load(object sender, EventArgs e)
        {

        }
        private void CarregarRegistroParaGlobal()
        {
            using (SQLiteConnection conexao = Banco.Conectar())
            {
                string sql = "SELECT * FROM pessoas WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TxtId.Text));

                using (SQLiteDataReader leitor = cmd.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        Global.Id = Convert.ToInt32(leitor["id"]);

                        Global.Nome = leitor["nome"].ToString();
                        Global.Endereco = leitor["endereco"].ToString();
                        Global.Cep = leitor["cep"].ToString();
                        Global.Estado = leitor["estado"].ToString();
                        Global.Cidade = leitor["cidade"].ToString();
                        Global.Nascimento = leitor["nascimento"].ToString();
                        Global.Sexo = leitor["sexo"].ToString();

                        Global.Cpf = leitor["cpf"].ToString();
                        Global.Rg = leitor["rg"].ToString();

                        Global.Bicicleta = leitor["bicicleta"].ToString();
                        Global.Moto = leitor["moto"].ToString();
                        Global.Auto = leitor["auto"].ToString();

                        Global.Ler = leitor["ler"].ToString();
                        Global.Musica = leitor["musica"].ToString();
                        Global.Cinema = leitor["cinema"].ToString();
                        Global.Bares = leitor["bares"].ToString();
                        Global.Conversar = leitor["conversar"].ToString();

                        Global.Futebol = leitor["futebol"].ToString();
                        Global.Basquete = leitor["basquete"].ToString();
                        Global.Volei = leitor["volei"].ToString();
                        Global.Atletismo = leitor["atletismo"].ToString();
                        Global.Pescaria = leitor["pescaria"].ToString();
                        Global.Paraquedismo = leitor["paraquedismo"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado.");
                    }
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (TxtId.Text == "")
            {
                MessageBox.Show("Digite um ID.");
                return;
            }

            using (SQLiteConnection conexao = Banco.Conectar())
            {
                string sql = "SELECT * FROM pessoas WHERE id=@id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TxtId.Text));

                using (SQLiteDataReader leitor = cmd.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        Global.Id = Convert.ToInt32(leitor["id"]);

                        CarregarRegistroParaGlobal();

                        FormDadosPessoais tela = new FormDadosPessoais();
                        tela.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ID não encontrado.");
                    }
                }
            }
        }
    }
}