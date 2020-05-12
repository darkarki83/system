using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW.Views
{
    public partial class TimerView : Form , ITimerView
    {
        public TimerView()
        {
            InitializeComponent();
        }

        private void TimerView_Load(object sender, EventArgs e)
        {
            var t = new Thread(new ThreadStart(ThreadProc1));
            t.Start();
        }

        private void ThreadProc1()
        {
            for (int i = 1; i <= 20; i++)
            {
                SetTextTimerSafe(i.ToString());
                Thread.Sleep(500);
            }
            Close();
        }

        private void SetTextTimerSafe(string text)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string>(s => { SetTextTimer(s); }), text);
            else
                SetTextTimer(text);
        }
        private void SetTextTimer(string text)
        {
            textTimer.Text = text;
        }
    }
}
