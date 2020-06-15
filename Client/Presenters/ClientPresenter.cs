using Client.Common;
using Client.DomainModel;
using Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Presenters
{
    public class ClientPresenter : BasePresenter<IClientView>
    {
        public IClientModel Model { get; set; }
        public ClientPresenter(IClientModel model, IClientView view)
        {
            Model = model;
            View = view;
        }
    }
}
