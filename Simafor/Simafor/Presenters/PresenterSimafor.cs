using Simafor.Common;
using Simafor.Model;
using Simafor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simafor.Presenters
{
    public class PresenterSimafor : BasePresenter<IViewSimafor>
    {
        public IModelSimafor Model { get; set; }

        public PresenterSimafor(IModelSimafor model, IViewSimafor view)
        {
            Model = model;
            View = view;

            View.CreateTread += CreateThread;
            View.NewDoubleClick += NewDoubleClick;
        }
        public void CreateThread(object sender, EventArgs e)
        {
            Model.CreateThread();
            View.ListNewThread.Items.Add($"{Model.MyThreads[Model.MyThreads.Count - 1].Thread.Name} => New Thread");
        }

        public void NewDoubleClick(object sender, EventArgs e)
        {
            int select = View.ListNewThread.SelectedIndex;
            Model.NewDoubleClick(select);
            Model.WaitThreads
        }
    }
}
