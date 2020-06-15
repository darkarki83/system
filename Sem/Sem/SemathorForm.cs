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
    public partial class SemathorForm : Form
    {
        private static object counterLock = new object();
        private static Semaphore semaphore;
        const string SemaphoreGuid = "99BEDCAF-DB63-42CC-A92E-0FF83D9CC23E";
        private int count = 0;

        public SemathorForm()
        {
            InitializeComponent();

            listBoxNew.DisplayMember = "Indexsator";
            listBoxWait.DisplayMember = "Indexsator";
            listBoxWork.DisplayMember = "Indexsator";
            //semaphore = new Semaphore(3, 3, SemaphoreGuid);
        }
        public void CaptureSemaphore()
        {
            semaphore.WaitOne();
        }
        public void ReleaseSemaphore()
        {
            semaphore.Release();
        }
        public void WorkWaitingThread(NewThread thread)
        {
            listBoxWork.Invoke((MethodInvoker)(() => listBoxWork.Items.Add(thread)));
            listBoxWait.Invoke((MethodInvoker)(() => listBoxWait.Items.Remove(thread)));
        }
        public void UpdateWorkingThread(NewThread thread)
        {
            int selectedIndex = 0;
            listBoxWork.Invoke((MethodInvoker)(() => selectedIndex = listBoxWork.SelectedIndex));
            int index = listBoxWork.Items.IndexOf(thread);

            if (index != -1 && index < listBoxWork.Items.Count)
            {
                listBoxWork.Invoke((MethodInvoker)(() => listBoxWork.Items.Remove(thread)));
                if (index < listBoxWork.Items.Count)
                {
                    listBoxWork.Invoke((MethodInvoker)(() => listBoxWork.Items.Insert(index, thread)));
                }
                else
                {
                    listBoxWork.Invoke((MethodInvoker)(() => listBoxWork.Items.Add(thread)));
                }
                listBoxWork.Invoke((MethodInvoker)(() => listBoxWork.SelectedIndex = selectedIndex));
            }
        }
        public void DeleteWorkingThread(NewThread thread)
        {
            listBoxWork.Invoke((MethodInvoker)(() => listBoxWork.Items.Remove(thread)));
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value != 0)
            {
                count++;
                NewThread thread = new NewThread(count, this);

                thread.Status = " new ";
                listBoxNew.Items.Add(thread);
            }
        }

        private void listBoxNew_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxNew.SelectedItem != null)
            {
                if(listBoxWork.Items.Count == 0)
                {
                    semaphore = new Semaphore((int)numericUpDown1.Value, (int)numericUpDown1.Value);
                }
                NewThread thread = listBoxNew.SelectedItem as NewThread;
                thread.Status = "Wait";
                listBoxWait.Invoke((MethodInvoker)(() => listBoxWait.Items.Add(thread)));
                listBoxWait.Invoke((MethodInvoker)(() => listBoxWait.Items.RemoveAt(listBoxNew.SelectedIndex)));
                thread.Start();
            }
        }

        private void listBoxWork_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxWork.SelectedIndex != null)
            {
                NewThread thread = listBoxWork.SelectedItem as NewThread;
                thread.StopThread = true;
                listBoxWork.Items.RemoveAt(listBoxWork.SelectedIndex);

            }
        }
    }
    public class NewThread
    {
        private SemathorForm form;
        private Thread thread;
        private System.Timers.Timer timer;

        public int Count { get; private set; }

        public bool StopThread { get; set; } = false;

        public int NumberName { get; set; }

        public string Status { get; set; }

        public string Indexsator { get => $"Thread {Count} --> {Status}"; }

        //public Thread Thread { get; }
        public NewThread(int count, SemathorForm Form)
        {
            Count = count;
            form = Form;
            thread = new Thread(Run);
            thread.IsBackground = true;
        }
        // все работает
        public NewThread(int count, SemathorForm Form, int number)
        {
            Count = count;
            NumberName = number;
            form = Form;
            thread = new Thread(Run);
            thread.IsBackground = true;
        }
        public void TimerGo(object sender, EventArgs e)
        {
            if(!StopThread)
            {
                NumberName++;
                Status = NumberName.ToString();
                form.UpdateWorkingThread(this);
            }
            else
            {
                form.ReleaseSemaphore();
                form.DeleteWorkingThread(this);
                timer.Stop();
                timer.Dispose();
            }
        }


        // Точка входа в поток (функция потока)
        public void Run()
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += TimerGo;
            timer.Interval = 1000;

            form.CaptureSemaphore();
            Status = NumberName.ToString();
            form.WorkWaitingThread(this);
            timer.Start();
        }
        public void Start()
        {
            thread.Start();
        }
        public void Stop()
        {
            thread.Abort();
        }
    }
}
