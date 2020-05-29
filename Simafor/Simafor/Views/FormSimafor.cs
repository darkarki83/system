using Simafor.Model;
using Simafor.Views;
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
using Timer = System.Threading.Timer;

namespace Simafor
{
    public partial class FormSimafor : Form , IViewSimafor
    {
        private List<NewThread> newThreads;
        private List<NewThread> waitThreads;
        private List<NewThread> workThreads;
        public event EventHandler CreateTread;
        public event EventHandler NewDoubleClick;
        public event EventHandler UpdateI;

        public ListView ListViewWork { get => listViewWork; set => listViewWork = value; }


        public ListBox ListNewThread { get => listBoxNew; set => listBoxNew = value; }
        public ListBox ListWaitThread { get => listBoxWait; set => listBoxWait = value; }
        public ListBox ListWorkThread { get => listBoxWork; set => listBoxWork = value; }
        public List<NewThread> NewThreads { get => newThreads; set => newThreads = value; }
        public List<NewThread> WaitThreads { get => waitThreads; set => waitThreads = value; }
        public List<NewThread> WorkThreads { get => workThreads; set => workThreads = value; }

        private TimerCallback tm;
        private Timer timer;
        private int num = 0;
        //public Timer Timer { get; set; }
        public FormSimafor()
        {
            InitializeComponent();
            //int num = 0;
            //// устанавливаем метод обратного вызова
            //tm = new TimerCallback(Update);
            //// создаем таймер
            //Timer timer = new Timer(tm, num, 0, 1000);

            newThreads = new List<NewThread>();
            waitThreads = new List<NewThread>();
            workThreads = new List<NewThread>();

            tm = new TimerCallback(Update);

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateTread(sender, e);
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
            if(ListViewWork.Items.Count == 0)
            {
                timer = new Timer(tm, num, 0, 1000);
            }

            if (ListNewThread.Items.Count > 0)
            {
                NewDoubleClick(sender, e);
            }
        }

        public void Update(object sender)
        {
            if (ListViewWork.Items.Count > 0)
            {
                UpdateI(sender, EventArgs.Empty);
            }
        }
    }
}
