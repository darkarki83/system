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

namespace Streams
{
    public partial class MyForm : Form
    {
        Thread t;
        int index;
        public MyForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                t = new Thread(new ThreadStart(ThreadProc1));
                t.Start();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                t.Abort();
                t = null;
            }
        }

        private void buttonDropping_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                SetLabel1Safe("0");
            }
            index = 0;
        }
        //
        // Для второго Label'1
        //
        private void SetLabel1Safe(string text)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string>(s => { SetLabel1(s); }), text);
            else
                SetLabel1(text);
        }
        private void SetLabel1(string text)
        {
            label1.Text = text;
        }
        //
        // Для второго Label'а
        //
        private void ThreadProc1()
        {
            while(true)
            {
                double aa = (index / 2);
                SetLabel1Safe(aa.ToString());
                Thread.Sleep(500);
                index++;
            }
        }
    }
}
