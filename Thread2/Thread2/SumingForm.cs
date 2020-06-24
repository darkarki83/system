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

namespace Thread2
{
    public partial class SumingForm : Form
    {
        private int sum = 0;
        private DateTime date;
        public SumingForm()
        {
            InitializeComponent();
        }

        private void SetLabelText2Safe(string text)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string>(s => { SetTextBox2(s); }), text);
            else
                SetTextBox2(text);
        }

        private void SetTextBox2(string text)
        {
            textBox2.Text = text;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            var t = new Thread(new ThreadStart(ThreadProc1));
            t.Start();
        }
        private void ThreadProc1()
        {
            date = DateTime.Now;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += tickTimer;
            timer.Start();
            int number = 0;
            try
            {
                number = int.Parse(textBox1.Text);
            }
            catch(Exception ex)
            {
                number = 1;
            }
            for (int i = 1; i <= number; i++)
            {
                sum += i;
                Thread.Sleep(10);
            }
            SetTextBox2(sum.ToString());
            timer.Stop();
            sum = 0;
        }

        private void tickTimer(object sender, EventArgs e)
        {
            SetTextBox2(sum.ToString());
        }
    }
}
