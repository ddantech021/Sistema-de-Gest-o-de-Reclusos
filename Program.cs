using System;
using System.Windows.Forms;
using SistemaGestaoReclusos.Forms.Login;
using System.Data;

namespace SistemaGestaoReclusos
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal do aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Verificar conexao com banco
            try
            {
                if (System.IO.File.Exists("config.txt"))
                {
                    string connString = System.IO.File.ReadAllText("config.txt");
                    SistemaGestaoReclusos.DataAccess.DatabaseConnection.Instance.ConnectionString = connString;
                }
            }
            catch { }

            Application.Run(new FormLogin());
        }
    }
}
