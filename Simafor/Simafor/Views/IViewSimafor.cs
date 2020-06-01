﻿using Simafor.Common;
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
        event EventHandler UpdateI;

        ListBox ListNewThread { get; set; }
        ListBox ListWaitThread { get; set; }
        ListBox ListWorkThread { get; set; }
        //ListView ListViewWork { get; set; }

        List<NewThread> NewThreads { get; set; }
        List<NewThread> WaitThreads { get; set; }
        List<NewThread> WorkThreads { get; set; }

        void listViewWorkSafe(string name, string stat);
        void listViewWorkSet(string name, string stat);
        string listViewWorkGet(int index);


        void Update(object sender);
    }
}
