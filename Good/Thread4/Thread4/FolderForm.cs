using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread4
{
    public partial class FolderForm : Form
    {
        public FolderForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            new CatalogForm(textBox1.Text).ShowDialog();
        }
    }
}
