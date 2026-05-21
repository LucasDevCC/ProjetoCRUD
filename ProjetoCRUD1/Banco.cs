using System.Data.SQLite;
using System.IO;
using SQLitePCL;

namespace ProjetoCRUD1
{
    public static class Banco
    {
        private static string caminho = "crud.db";

        public static SQLiteConnection Conectar()
        {
            Batteries.Init();

            if (!File.Exists(caminho))
            {
                SQLiteConnection.CreateFile(caminho);
            }

            SQLiteConnection conexao = new SQLiteConnection("Data Source=" + caminho);
            conexao.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS pessoas (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                nome TEXT,
                endereco TEXT,
                cep TEXT,
                estado TEXT,
                cidade TEXT,
                nascimento TEXT,
                sexo TEXT,
                cpf TEXT,
                rg TEXT,
                bicicleta TEXT,
                moto TEXT,
                auto TEXT,
                ler TEXT,
                musica TEXT,
                cinema TEXT,
                bares TEXT,
                conversar TEXT,
                futebol TEXT,
                basquete TEXT,
                volei TEXT,
                atletismo TEXT,
                pescaria TEXT,
                paraquedismo TEXT
            )";

            SQLiteCommand comando = new SQLiteCommand(sql, conexao);
            comando.ExecuteNonQuery();

            return conexao;
        }
    }
}