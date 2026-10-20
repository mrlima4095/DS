using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturante
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Splash splash = new Splash())
            {
                splash.ShowDialog();
            }

            Conta usuario = null;

            using (LoginForm login = new LoginForm())
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                usuario = login.Usuario;
            }

            Form1 form1 = new Form1();
            form1.UsuarioLogado = usuario;
            Application.Run(form1);
        }
    }
}
