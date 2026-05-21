using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCRUD1
{
    public static class Global
    {
        public static string Operacao = "";

        public static int Id = 0;
        public static string Nome = "";
        public static string Endereco = "";
        public static string Cep = "";
        public static string Estado = "";
        public static string Cidade = "";
        public static string Nascimento = "";
        public static string Sexo = "";

        public static string Cpf = "";
        public static string Rg = "";

        public static string Bicicleta = "";
        public static string Moto = "";
        public static string Auto = "";

        public static string Ler = "";
        public static string Musica = "";
        public static string Cinema = "";
        public static string Bares = "";
        public static string Conversar = "";

        public static string Futebol = "";
        public static string Basquete = "";
        public static string Volei = "";
        public static string Atletismo = "";
        public static string Pescaria = "";
        public static string Paraquedismo = "";

        public static void LimparTudo()
        {
            Id = 0;
            Nome = "";
            Endereco = "";
            Cep = "";
            Estado = "";
            Cidade = "";
            Nascimento = "";
            Sexo = "";
            Cpf = "";
            Rg = "";

            Bicicleta = "";
            Moto = "";
            Auto = "";

            Ler = "";
            Musica = "";
            Cinema = "";
            Bares = "";
            Conversar = "";

            Futebol = "";
            Basquete = "";
            Volei = "";
            Atletismo = "";
            Pescaria = "";
            Paraquedismo = "";
        }
    }
}
