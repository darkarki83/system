using Simafor.Common;
using Simafor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simafor.Views
{
    public interface IViewSimafor : IView
    {
        event EventHandler CreateTread;
        event EventHandler NewDoubleClick;

        ListBox ListNewThread { get; set; }
        ListBox ListWaitThread { get; set; }
        ListBox ListWorkThread { get; set; }

        List<NewThread> NewThreads { get; set; }
        List<NewThread> WaitThreads { get; set; }
        List<NewThread> WorkThreads { get; set; }
    }
}
