using Client.DomainModel;
using Client.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var login = new LogInForm();
            Application.Run(login);
            if (login.DialogResult == DialogResult.OK)
            {
                var clientPresenter = new ClientPresenter(new ClientModel(login.Names, login.Ip, login.Port), new ClientForm());
                Application.Run((Form)clientPresenter.View);
            }

        }
    }
}
