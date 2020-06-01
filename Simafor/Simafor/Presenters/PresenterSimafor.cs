using Simafor.Common;
using Simafor.Model;
using Simafor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simafor.Presenters
{
    public class PresenterSimafor : BasePresenter<IViewSimafor>
    {
        private static object counterLock = new object();
        public IModelSimafor Model { get; set; }

        public PresenterSimafor(IModelSimafor model, IViewSimafor view)
        {
            Model = model;
            View = view;

            View.CreateTread += CreateThread;
            View.NewDoubleClick += NewDoubleClick;
            View.UpdateI += UpdateI;
        }
        public void CreateThread(object sender, EventArgs e)
        {
            Model.CreateThread();
            View.ListNewThread.Items.Add(Model.MyThreads[Model.MyThreads.Count - 1]);
        }

        public void NewDoubleClick(object sender, EventArgs e)
        {
            int select = View.ListNewThread.SelectedIndex;
            Model.NewDoubleClick(select);
            Model.WaitThreads[Model.WaitThreads.Count - 1].Thread.Start();
            View.ListNewThread.Items.RemoveAt(select);
            if (Model.CountWork <= 3)
            {
                ListViewItem item = new ListViewItem();
                View.listViewWorkSafe(Model.WaitThreads[Model.WaitThreads.Count - 1].Thread.Name, Model.WaitThreads[Model.WaitThreads.Count - 1].I.ToString());
            }
            else
            {
                //View.ListWaitThread.Items.Add(Model.WaitThreads[Model.WaitThreads.Count - 1].Thread.Name, " => Wait");
            }

        }

        public void UpdateI(object sender, EventArgs e)
        {
            int j = 0;
              lock (counterLock)
                {
                    foreach (var item in Model.WaitThreads)
                    {
          
                        if (true)
                        {
                        View.listViewWorkSafe(item.Thread.Name.ToString(), item.I.ToString());
                        }
                        j++;
                        //View.ListNewThread.Items.Add(Model.MyThreads[Model.MyThreads.Count - 1]);
                    }
                }
           
        }
    }
}
