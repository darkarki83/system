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
            var logInPresenter = new LogInPresenter(new ClientModel(), new LogInForm());
            Application.Run((Form)logInPresenter.View);
        }
    }
}
