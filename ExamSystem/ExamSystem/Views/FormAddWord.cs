using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem.Views
{
    public partial class FormAddWord : Form, IFormAddWord
    {
        public string NewWord { get => textBoxWord.Text; set => textBoxWord.Text = value; }
        public event EventHandler AddNewW;
        public FormAddWord()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            AddNewW(sender, e);
            Close();
        }

        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {
            if (textBoxWord.TextLength > 0)
            {
                buttonAddNew.Enabled = true;
            }
            else
            {
                buttonAddNew.Enabled = false;
            }
        }
    }
}
