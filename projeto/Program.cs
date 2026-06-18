using System;
using System.Windows.Forms;
using projeto.Data; // IMPORTANTE: Para o programa achar a conexão

namespace projeto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Cria o banco e a tabela antes da tela abrir!
            DatabaseConnection.InicializarBanco();

            Application.Run(new FormLogin());
        }
    }
}