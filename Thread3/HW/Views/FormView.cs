using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW.Views

{
    public partial class FormView : Form, IFormView
    {

        public event EventHandler Start;
        public FormView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Start != null)
                Start(sender, e);
        }
    }
}
