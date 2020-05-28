using Simafor.Model;
using Simafor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simafor
{
    public partial class FormSimafor : Form , IViewSimafor
    {
        private List<NewThread> newThreads;
        private List<NewThread> waitThreads;
        private List<NewThread> workThreads;
        public event EventHandler CreateTread;
        public event EventHandler NewDoubleClick;
        public ListBox ListNewThread { get => listBoxNew; set => listBoxNew = value; }
        public ListBox ListWaitThread { get => listBoxWait; set => listBoxWait = value; }
        public ListBox ListWorkThread { get => listBoxWork; set => listBoxWork = value; }
        public List<NewThread> NewThreads { get => newThreads; set => newThreads = value; }
        public List<NewThread> WaitThreads { get => waitThreads; set => waitThreads = value; }
        public List<NewThread> WorkThreads { get => workThreads; set => workThreads = value; }

        public FormSimafor()
        {
            InitializeComponent();
            newThreads = new List<NewThread>();
            waitThreads = new List<NewThread>();
            workThreads = new List<NewThread>();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateTread(sender, e);
        }

        private void listBoxNew_Click(object sender, EventArgs e)
        {

        }

        private void listBoxWait_Click(object sender, EventArgs e)
        {

        }

        private void listBoxWork_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBoxNew_DoubleClick(object sender, EventArgs e)
        {
            if(ListNewThread.Items.Count > 0)
            {
                NewDoubleClick(sender, e);
            }
        }
    }
}
