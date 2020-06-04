using ExamSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class FormExam : Form, IFormExam
    {
        public event EventHandler AddWord;
        public event EventHandler AddFromFile;
        public event EventHandler CloseForm;
        public event EventHandler StartSearch;

        public ListBox ListBoxWord { get => listBoxWord; set => listBoxWord = value; }
        public ProgressBar Progress { get => progressBar; set => progressBar = value; }
        public System.Windows.Forms.Label LabelProgres { get => labelProgress; set => labelProgress = value; }
        public FormExam()
        {
            InitializeComponent();
            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddWord != null)
                AddWord(sender, e);
            if(ListBoxWord.Items.Count > 0)
                buttonDelete.Enabled = true;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            AddFromFile(sender, e);
            if (ListBoxWord.Items.Count > 0)
                buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(ListBoxWord.SelectedIndex >= 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove word", "Delete word", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    ListBoxWord.Items.RemoveAt(ListBoxWord.SelectedIndex);
            }
            if (ListBoxWord.Items.Count == 0)
                buttonDelete.Enabled = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm(sender, e);
            Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartSearch(sender, e);
        }
    }
}
