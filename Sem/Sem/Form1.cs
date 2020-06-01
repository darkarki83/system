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

namespace Sem
{
    public partial class Form1 : Form
    {
        private static object counterLock = new object();

        private List<NewThread> myThreads;
        public List<NewThread> MyThreads { get => myThreads; set => myThreads = value; }
        
        private static Semaphore semaphore;
        const string SemaphoreGuid = "99BEDCAF-DB63-42CC-A92E-0FF83D9CC23E";

        private TimerCallback tm;
        private System.Timers.Timer timer;
        private int num = 0;

        public int ThreadNum { get; set; }
        public Form1()
        {
            InitializeComponent();

            semaphore = new Semaphore(3, 3, SemaphoreGuid);
            myThreads = new List<NewThread>();
                 
            ThreadNum = 1;

            //tm = new TimerCallback(Update);

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            timer.Elapsed += Update;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MyThreads.Add(new NewThread(ThreadNum, semaphore));
            ThreadNum++;

            ListViewNewSafeSet(MyThreads[MyThreads.Count - 1].Thread.Name, "New");
        }
        public void ListViewWorkSafeSet(string name, string stat)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string, string>((n, s) => { listViewWorkSet(n, s); }), (name, stat));
            else
                listViewWorkSet(name, stat);
        }

        public void listViewWorkSet(string name, string stat)
        {
            ListViewItem item = new ListViewItem();
            listViewWork.Items.Add(item);
            item.Text = name;
            item.SubItems.Add(stat);
        }

        public string ListViewWorkGet(int index)
        {
            lock(counterLock)
            {
                return listViewWork.Items[index].Text;
            }
        }
        public void ListViewWaitSafeSet(string name, string stat)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string, string>((n, s) => { listViewWaitSet(n, s); }), (name, stat));
            else
                listViewWaitSet(name, stat);
        }

        public void listViewWaitSet(string name, string stat)
        {
            ListViewItem item = new ListViewItem();
            listViewWait.Items.Add(item);
            item.Text = name;
            item.SubItems.Add(stat);
        }

        public string ListViewWaitGet(int index)
        {
            return listViewWait.Items[index].Text;
        }
        public void ListViewNewSafeSet(string name, string stat)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string, string>((n, s) => { listViewNewSet(n, s); }), (name, stat));
            else
                listViewNewSet(name, stat);
        }

        public void listViewNewSet(string name, string stat)
        {
            ListViewItem item = new ListViewItem();
            listViewNew.Items.Add(item);
            item.Text = name;
            item.SubItems.Add(stat);
        }

        public string ListViewNewGet(int index)
        {
            return listViewNew.Items[index].Text;
        }

        private void listViewNew_DoubleClick(object sender, EventArgs e)
        {
            int index = listViewNew.SelectedIndices[0];
            if(semaphore.WaitOne(0))
            {
                foreach (var item in MyThreads)
                {
                    if(ListViewNewGet(index) == item.Thread.Name)
                    {
                        listViewNew.Items.RemoveAt(index);
                        item.Where = 3;
                        item.Thread.Start();
                        ListViewWorkSafeSet(item.Thread.Name, item.I.ToString());
                        break;
                    }
                } 
            }
            else
            {
                foreach (var item in MyThreads)
                {
                    if (ListViewNewGet(index) == item.Thread.Name)
                    {
                        listViewNew.Items.RemoveAt(index);
                        item.Where = 2;
                        //item.Thread.Start();
                        ListViewWaitSafeSet(item.Thread.Name, "Wait");
                        break;
                    }
                }
            }
        }
        private void listViewWork_DoubleClick(object sender, EventArgs e)
        {
            int index = listViewWork.SelectedIndices[0];
            int i = 0;
            foreach (var item in MyThreads)
            {
                if (ListViewWorkGet(index) == item.Thread.Name)
                {
                    item.Stop = true;
                    item.Where = 0;
                    listViewWork.Items.RemoveAt(index);
                    break;
                }
                i++;
            }
            if (listViewWait.Items.Count > 0)
            {
                foreach (var item in MyThreads)
                {
                    if (ListViewWaitGet(0) == item.Thread.Name)
                    {
                        item.Where = 3;
                        item.Thread.Start();
                        ListViewWorkSafeSet(item.Thread.Name, item.I.ToString());
                        listViewWait.Items.RemoveAt(0);
                        break;
                    }
                }
            }
        }
        public void Update(object sender, EventArgs e)
        {
            if (listViewWork.Items.Count > 0)
            {
                for (int i = 0; i < listViewWork.Items.Count; i++)
                {
                    foreach (var item in MyThreads)
                    {
                        if (ListViewWorkGet(i) == item.Thread.Name)
                        {
                            ListViewWorkSafeSet(item.Thread.Name, item.I.ToString());
                            break;
                        }
                    }
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (listViewWork.Items.Count > 0)
            {
                for (int i = 0; i < listViewWork.Items.Count; i++)
                {
                    foreach (var item in MyThreads)
                    {
                        if (ListViewWorkGet(i) == item.Thread.Name)
                        {
                            ListViewWorkSafeSet(item.Thread.Name, item.I.ToString());
                            break;
                        }
                    }
                }
            }
        }
    }
    public class NewThread
    {
        private Semaphore semaphore;
        public bool Stop { get; set; }
        public int Where { get; set; }
        public int NumberName { get; set; }
        public int I { get; set; }
        public Thread Thread { get; }
        public NewThread(int number, Semaphore s)
        {
            Where = 1;
            semaphore = s;
            NumberName = number;
            Thread = new Thread(new ThreadStart(Run));
            Thread.Name = $"Thread {NumberName.ToString()}";
            Stop = false;
        }
        // Точка входа в поток (функция потока)
        public void Run()
        {
            semaphore.WaitOne();
            // Получаем мьютекс (если он занят, то будем ждать, пока не освободиться)
            for (I = 0; I < 10000; I++)
            {
                Thread.Sleep(1000);
                if (Stop)
                    break;
            }
            semaphore.Release();
        }
    }
}
