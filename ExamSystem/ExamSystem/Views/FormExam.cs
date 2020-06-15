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
        public event EventHandler Cancel;
        public event EventHandler Continue;
        public event EventHandler Pause;

        public ListBox ListBoxWord { get => listBoxWord; set => listBoxWord = value; }
        public ProgressBar Progress { get => progressBar; set => progressBar = value; }
        public System.Windows.Forms.Label LabelProgres { get => labelProgress; set => labelProgress = value; }
        public FormExam()
        {
            InitializeComponent();
            buttonDelete.Enabled = false;
            EnableButton(true, false, false, false);
        }
        public void EnableButton(bool isS, bool isC, bool isP, bool isCon)
        {
            buttonStart.Enabled = isS;
            toolStripButtonStart.Enabled = isS;
            startSearchToolStripMenuItem.Enabled = isS;
            buttonCancel.Enabled = isC;
            toolStripButtonCancel.Enabled = isC;
            cancelToolStripMenuItem.Enabled = isC;
            buttonPause.Enabled = isP;
            pauseToolStripMenuItem.Enabled = isP;
            buttonContinue.Enabled = isCon;
            continueToolStripMenuItem.Enabled = isCon;

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
            if (ListBoxWord.SelectedIndex >= 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove word", "Delete word", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    List<int> list = new List<int>();
                    foreach (var index in ListBoxWord.SelectedIndices)
                    {
                        list.Add((int)index);
                    }
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        ListBoxWord.Items.RemoveAt(list[i]);
                    }
                }
            }
            if (ListBoxWord.Items.Count == 0)
                buttonDelete.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartSearch(sender, e);
            EnableButton(false, true, true, false);
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            Pause(sender, e);
            EnableButton(false, true, false, true);
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Continue(sender, e);
            EnableButton(false, true, true, false);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel(sender, e);
            EnableButton(true, false, false, false);

        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm(sender, e);
            Close();
        }

        private void NewFileMenuItem_Click(object sender, EventArgs e)
        {
            ListBoxWord.Items.Clear();
        }
    }
}
