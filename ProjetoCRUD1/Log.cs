using System;
using System.IO;

namespace ProjetoCRUD1
{
    public static class Log
    {
        public static void Registrar(string texto)
        {
            string linha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + texto;
            File.AppendAllText("log.txt", linha + Environment.NewLine);
        }
    }
}