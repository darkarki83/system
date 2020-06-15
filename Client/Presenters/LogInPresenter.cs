using Client.Common;
using Client.DomainModel;
using Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Presenters
{
    public class LogInPresenter: BasePresenter<ILogInView>
    {
        public IClientModel Model { get; set; }
        public LogInPresenter(IClientModel model, ILogInView view)
        {
            Model = model;
            View = view;

            View.LogIn += LogIn;

        }

        public void LogIn(object sender, EventArgs e)
        {

            var clientPresenter = new ClientPresenter(Model, new ClientForm());
            ((Form)clientPresenter.View).ShowDialog();
        }
        public void Load(object sender, EventArgs e)
        {
        }
    }
}
