using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonCopy.Enabled = false;
        }

        private void buttonFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Text files (*.txt)|*.txt|C++ files (*.cpp;*.h;*.hpp)|*.cpp;*.h;*.hpp|All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFrom.Text = fileDialog.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not open File " + ex.Message, "File Open", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonToFile_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Text files (*.txt)|*.txt|C++ files (*.cpp;*.h;*.hpp)|*.cpp;*.h;*.hpp|All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxTo.Text = fileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open File " + ex.Message, "File Open", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void buttonCopy_Click(object sender, EventArgs e)
        {
           
            // Создаем объект класса System.Progress. Именно в нем мы обращаемся к UI.
            var progress = new Progress<Tuple<int>>(t =>
            {
                progressBar.Value = t.Item1;
            });
            // Запускаем асинхронную операцию
            await Task.Factory.StartNew(() => SomeLongOperation(progress), TaskCreationOptions.LongRunning);
        }
        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            if(textBoxFrom.TextLength > 0 && textBoxTo.TextLength > 0)
            {
                buttonCopy.Enabled = true;
            }
        }
        private async void SomeLongOperation(IProgress<Tuple<int>> progress)
        {
            // ВАЖНО: Здесь никогда не обращайтесь к UI (т.е., к форме и ее контролам)
            string textFromFile = "";
            using (FileStream fstream = File.OpenRead($"{textBoxFrom.Text}"))
            {
                byte[] array = new byte[fstream.Length];
                // асинхронное чтение файла
                await fstream.ReadAsync(array, 0, array.Length);

                textFromFile = System.Text.Encoding.Default.GetString(array);
            }
            string files = string.Empty;
            textBoxTo.Invoke((MethodInvoker)(() => files = textBoxTo.Text));

            using (FileStream fstream2 = new FileStream(textBoxTo.Text, FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes(textFromFile);
                int count = Encoding.Default.GetByteCount(textFromFile);
                int k = count / 100;
                for (int i = 0; i <= 100; i++)
                {
                    Task.Delay(100).Wait();
                    if (i != 100)
                    {
                        fstream2.Write(array, i * k, k);
                    }
                    else
                    {
                        fstream2.Write(array, i * k, count - i * k);
                    }
                    progress.Report(new Tuple<int>(i));
                }
            }
        }
    }
}
