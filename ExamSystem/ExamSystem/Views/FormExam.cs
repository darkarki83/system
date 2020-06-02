using ExamSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class FormExam : Form, IFormExam
    {
        public event EventHandler AddWord;
        public ListBox ListBoxWord { get => listBoxWord; set => listBoxWord = value; }
        public FormExam()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddWord != null)
                AddWord(sender, e);
            
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {

        }
    }
}
